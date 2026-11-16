using System.Collections.Generic;

namespace SistemaGestionUniversitaria
{
    class Estudiante
    {
        public string Cedula;
        public string Nombre;
        public override string ToString() { return Cedula + " - " + Nombre; }
    }

    class Curso
    {
        public string Codigo;
        public string Nombre;
        public bool Activo;
        public override string ToString() { return Codigo + " - " + Nombre; }
    }

    class Matricula
    {
        public string CedulaEstudiante;
        public string CodigoCurso;
        public List<double> Notas = new List<double>();
    }
}
