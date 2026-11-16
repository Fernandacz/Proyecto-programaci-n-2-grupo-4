using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionUniversitaria
{
    public partial class Form1 : Form
    {
        // Datos en memoria
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Curso> cursos = new List<Curso>();
        List<Matricula> matriculas = new List<Matricula>();

        public Form1()
        {
            InitializeComponent();
        }

        void Info(string mensaje) { MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        void Error(string mensaje) { MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        void RefrescarListas()
        {
            lstEstudiantes.Items.Clear();
            lstEstudiantes.Items.AddRange(estudiantes.ToArray());

            var activos = cursos.Where(c => c.Activo).ToArray();
            lstCursosActivos.Items.Clear();
            lstCursosActivos.Items.AddRange(activos);

            foreach (ComboBox c in new[] { cmbMatEst, cmbNotaEst, cmbConsEst })
            {
                c.Items.Clear();
                c.Items.AddRange(estudiantes.ToArray());
            }

            foreach (ComboBox c in new[] { cmbMatCurso, cmbNotaCurso })
            {
                c.Items.Clear();
                c.Items.AddRange(activos);
            }

            cmbConsCurso.Items.Clear();
            cmbConsCurso.Items.AddRange(cursos.ToArray());
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombreEst.Text.Trim();

            if (cedula == "" || nombre == "") { Error("Complete la cedula y el nombre."); return; }
            if (estudiantes.Any(x => x.Cedula == cedula)) { Error("El estudiante ya esta registrado."); return; }

            estudiantes.Add(new Estudiante { Cedula = cedula, Nombre = nombre });
            txtCedula.Clear();
            txtNombreEst.Clear();
            RefrescarListas();
            Info("Estudiante registrado correctamente.");
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombreCurso.Text.Trim();

            if (codigo == "" || nombre == "") { Error("Complete el codigo y el nombre."); return; }
            if (cursos.Any(c => c.Codigo == codigo)) { Error("El curso ya existe."); return; }

            cursos.Add(new Curso { Codigo = codigo, Nombre = nombre, Activo = true });
            txtCodigo.Clear();
            txtNombreCurso.Clear();
            RefrescarListas();
            Info("Curso registrado correctamente.");
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Estudiante est = cmbMatEst.SelectedItem as Estudiante;
            Curso curso = cmbMatCurso.SelectedItem as Curso;

            if (est == null || curso == null) { Error("Seleccione un estudiante y un curso."); return; }
            if (!curso.Activo) { Error("Curso inactivo."); return; }

            bool existe = matriculas.Any(m => m.CedulaEstudiante == est.Cedula && m.CodigoCurso == curso.Codigo);
            if (existe) { Error("El estudiante ya esta matriculado en este curso."); return; }

            matriculas.Add(new Matricula { CedulaEstudiante = est.Cedula, CodigoCurso = curso.Codigo });
            Info("Matricula realizada correctamente.");
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            Estudiante est = cmbNotaEst.SelectedItem as Estudiante;
            Curso curso = cmbNotaCurso.SelectedItem as Curso;

            if (est == null || curso == null) { Error("Seleccione un estudiante y un curso."); return; }

            Matricula m = matriculas.FirstOrDefault(x => x.CedulaEstudiante == est.Cedula && x.CodigoCurso == curso.Codigo);
            if (m == null) { Error("No existe una matricula para estos datos."); return; }

            double nota;
            if (!double.TryParse(txtNota.Text, out nota)) { Error("Ingrese un numero valido."); return; }
            if (nota < 0 || nota > 100) { Error("La nota debe estar entre 0 y 100."); return; }

            m.Notas.Add(nota);
            txtNota.Clear();
            Info("Calificacion registrada correctamente.");
        }

        private void btnPromEst_Click(object sender, EventArgs e)
        {
            Estudiante est = cmbConsEst.SelectedItem as Estudiante;
            if (est == null) { Error("Seleccione un estudiante."); return; }

            List<double> notas = matriculas
                .Where(m => m.CedulaEstudiante == est.Cedula)
                .SelectMany(m => m.Notas)
                .ToList();

            string texto = "Estudiante: " + est.Nombre + Environment.NewLine;
            texto += notas.Count == 0
                ? "El estudiante no tiene calificaciones."
                : "Promedio general: " + notas.Average().ToString("F2");

            txtResultado.Text = texto;
        }

        private void btnPromCurso_Click(object sender, EventArgs e)
        {
            Curso curso = cmbConsCurso.SelectedItem as Curso;
            if (curso == null) { Error("Seleccione un curso."); return; }

            List<double> notas = matriculas
                .Where(m => m.CodigoCurso == curso.Codigo)
                .SelectMany(m => m.Notas)
                .ToList();

            string texto = "Curso: " + curso.Nombre + Environment.NewLine;
            texto += notas.Count == 0
                ? "El curso no tiene calificaciones registradas."
                : "Promedio general del curso: " + notas.Average().ToString("F2");

            txtResultado.Text = texto;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Estudiante est = cmbConsEst.SelectedItem as Estudiante;
            if (est == null) { Error("Seleccione un estudiante."); return; }

            string nl = Environment.NewLine;
            string texto = "Estudiante: " + est.Nombre + nl + "Cedula: " + est.Cedula + nl + nl;
            texto += "--- CURSOS MATRICULADOS ---" + nl;

            var lista = matriculas.Where(m => m.CedulaEstudiante == est.Cedula).ToList();

            if (lista.Count == 0)
                texto += "No tiene cursos matriculados." + nl;

            foreach (Matricula m in lista)
            {
                Curso curso = cursos.FirstOrDefault(c => c.Codigo == m.CodigoCurso);
                if (curso == null) continue;

                texto += nl + "Curso: " + curso.Nombre + nl;
                texto += "Codigo: " + curso.Codigo + nl;
                texto += "Estado: " + (curso.Activo ? "Activo" : "Inactivo") + nl;

                if (m.Notas.Count == 0)
                {
                    texto += "Sin calificaciones." + nl;
                }
                else
                {
                    texto += "Notas: " + string.Join(", ", m.Notas) + nl;
                    texto += "Promedio del curso: " + m.Notas.Average().ToString("F2") + nl;
                }
            }

            txtResultado.Text = texto;
        }
    }
}
