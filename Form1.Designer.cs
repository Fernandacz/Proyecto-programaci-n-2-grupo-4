namespace SistemaGestionUniversitaria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabEstudiantes = new System.Windows.Forms.TabPage();
            lblCedula = new System.Windows.Forms.Label();
            txtCedula = new System.Windows.Forms.TextBox();
            lblNombreEst = new System.Windows.Forms.Label();
            txtNombreEst = new System.Windows.Forms.TextBox();
            btnRegistrarEstudiante = new System.Windows.Forms.Button();
            lstEstudiantes = new System.Windows.Forms.ListBox();
            tabCursos = new System.Windows.Forms.TabPage();
            lblCodigo = new System.Windows.Forms.Label();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblNombreCurso = new System.Windows.Forms.Label();
            txtNombreCurso = new System.Windows.Forms.TextBox();
            btnRegistrarCurso = new System.Windows.Forms.Button();
            lblCursosActivos = new System.Windows.Forms.Label();
            lstCursosActivos = new System.Windows.Forms.ListBox();
            tabMatricula = new System.Windows.Forms.TabPage();
            lblMatEst = new System.Windows.Forms.Label();
            cmbMatEst = new System.Windows.Forms.ComboBox();
            lblMatCurso = new System.Windows.Forms.Label();
            cmbMatCurso = new System.Windows.Forms.ComboBox();
            btnMatricular = new System.Windows.Forms.Button();
            tabNotas = new System.Windows.Forms.TabPage();
            lblNotaEst = new System.Windows.Forms.Label();
            cmbNotaEst = new System.Windows.Forms.ComboBox();
            lblNotaCurso = new System.Windows.Forms.Label();
            cmbNotaCurso = new System.Windows.Forms.ComboBox();
            lblNota = new System.Windows.Forms.Label();
            txtNota = new System.Windows.Forms.TextBox();
            btnRegistrarNota = new System.Windows.Forms.Button();
            tabConsultas = new System.Windows.Forms.TabPage();
            lblConsEst = new System.Windows.Forms.Label();
            cmbConsEst = new System.Windows.Forms.ComboBox();
            btnPromEst = new System.Windows.Forms.Button();
            btnInfo = new System.Windows.Forms.Button();
            lblConsCurso = new System.Windows.Forms.Label();
            cmbConsCurso = new System.Windows.Forms.ComboBox();
            btnPromCurso = new System.Windows.Forms.Button();
            txtResultado = new System.Windows.Forms.TextBox();
            tabControl1.SuspendLayout();
            tabEstudiantes.SuspendLayout();
            tabCursos.SuspendLayout();
            tabMatricula.SuspendLayout();
            tabNotas.SuspendLayout();
            tabConsultas.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabEstudiantes);
            tabControl1.Controls.Add(tabCursos);
            tabControl1.Controls.Add(tabMatricula);
            tabControl1.Controls.Add(tabNotas);
            tabControl1.Controls.Add(tabConsultas);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(544, 421);
            tabControl1.TabIndex = 0;
            // 
            // tabEstudiantes
            // 
            tabEstudiantes.BackColor = System.Drawing.Color.PaleTurquoise;
            tabEstudiantes.Controls.Add(lblCedula);
            tabEstudiantes.Controls.Add(txtCedula);
            tabEstudiantes.Controls.Add(lblNombreEst);
            tabEstudiantes.Controls.Add(txtNombreEst);
            tabEstudiantes.Controls.Add(btnRegistrarEstudiante);
            tabEstudiantes.Controls.Add(lstEstudiantes);
            tabEstudiantes.ForeColor = System.Drawing.SystemColors.ControlText;
            tabEstudiantes.Location = new System.Drawing.Point(4, 24);
            tabEstudiantes.Name = "tabEstudiantes";
            tabEstudiantes.Size = new System.Drawing.Size(536, 393);
            tabEstudiantes.TabIndex = 0;
            tabEstudiantes.Text = "Estudiantes";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new System.Drawing.Point(20, 23);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new System.Drawing.Size(47, 15);
            lblCedula.TabIndex = 0;
            lblCedula.Text = "Cedula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new System.Drawing.Point(110, 20);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(200, 23);
            txtCedula.TabIndex = 0;
            // 
            // lblNombreEst
            // 
            lblNombreEst.AutoSize = true;
            lblNombreEst.Location = new System.Drawing.Point(20, 58);
            lblNombreEst.Name = "lblNombreEst";
            lblNombreEst.Size = new System.Drawing.Size(54, 15);
            lblNombreEst.TabIndex = 1;
            lblNombreEst.Text = "Nombre:";
            // 
            // txtNombreEst
            // 
            txtNombreEst.Location = new System.Drawing.Point(110, 55);
            txtNombreEst.Name = "txtNombreEst";
            txtNombreEst.Size = new System.Drawing.Size(200, 23);
            txtNombreEst.TabIndex = 1;
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.Location = new System.Drawing.Point(20, 90);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new System.Drawing.Size(150, 27);
            btnRegistrarEstudiante.TabIndex = 2;
            btnRegistrarEstudiante.Text = "Registrar estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += btnRegistrarEstudiante_Click;
            // 
            // lstEstudiantes
            // 
            lstEstudiantes.FormattingEnabled = true;
            lstEstudiantes.ItemHeight = 15;
            lstEstudiantes.Location = new System.Drawing.Point(20, 130);
            lstEstudiantes.Name = "lstEstudiantes";
            lstEstudiantes.Size = new System.Drawing.Size(496, 244);
            lstEstudiantes.TabIndex = 3;
            // 
            // tabCursos
            // 
            tabCursos.BackColor = System.Drawing.Color.PaleTurquoise;
            tabCursos.Controls.Add(lblCodigo);
            tabCursos.Controls.Add(txtCodigo);
            tabCursos.Controls.Add(lblNombreCurso);
            tabCursos.Controls.Add(txtNombreCurso);
            tabCursos.Controls.Add(btnRegistrarCurso);
            tabCursos.Controls.Add(lblCursosActivos);
            tabCursos.Controls.Add(lstCursosActivos);
            tabCursos.Location = new System.Drawing.Point(4, 24);
            tabCursos.Name = "tabCursos";
            tabCursos.Size = new System.Drawing.Size(536, 393);
            tabCursos.TabIndex = 1;
            tabCursos.Text = "Cursos";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new System.Drawing.Point(20, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(110, 20);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(200, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblNombreCurso
            // 
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.Location = new System.Drawing.Point(20, 58);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new System.Drawing.Size(54, 15);
            lblNombreCurso.TabIndex = 1;
            lblNombreCurso.Text = "Nombre:";
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new System.Drawing.Point(110, 55);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new System.Drawing.Size(200, 23);
            txtNombreCurso.TabIndex = 1;
            // 
            // btnRegistrarCurso
            // 
            btnRegistrarCurso.Location = new System.Drawing.Point(20, 90);
            btnRegistrarCurso.Name = "btnRegistrarCurso";
            btnRegistrarCurso.Size = new System.Drawing.Size(150, 27);
            btnRegistrarCurso.TabIndex = 2;
            btnRegistrarCurso.Text = "Registrar curso";
            btnRegistrarCurso.UseVisualStyleBackColor = true;
            btnRegistrarCurso.Click += btnRegistrarCurso_Click;
            // 
            // lblCursosActivos
            // 
            lblCursosActivos.AutoSize = true;
            lblCursosActivos.Location = new System.Drawing.Point(20, 128);
            lblCursosActivos.Name = "lblCursosActivos";
            lblCursosActivos.Size = new System.Drawing.Size(86, 15);
            lblCursosActivos.TabIndex = 3;
            lblCursosActivos.Text = "Cursos activos:";
            // 
            // lstCursosActivos
            // 
            lstCursosActivos.FormattingEnabled = true;
            lstCursosActivos.ItemHeight = 15;
            lstCursosActivos.Location = new System.Drawing.Point(20, 150);
            lstCursosActivos.Name = "lstCursosActivos";
            lstCursosActivos.Size = new System.Drawing.Size(496, 229);
            lstCursosActivos.TabIndex = 3;
            // 
            // tabMatricula
            // 
            tabMatricula.BackColor = System.Drawing.Color.PaleTurquoise;
            tabMatricula.Controls.Add(lblMatEst);
            tabMatricula.Controls.Add(cmbMatEst);
            tabMatricula.Controls.Add(lblMatCurso);
            tabMatricula.Controls.Add(cmbMatCurso);
            tabMatricula.Controls.Add(btnMatricular);
            tabMatricula.Location = new System.Drawing.Point(4, 24);
            tabMatricula.Name = "tabMatricula";
            tabMatricula.Size = new System.Drawing.Size(536, 393);
            tabMatricula.TabIndex = 2;
            tabMatricula.Text = "Matricula";
            // 
            // lblMatEst
            // 
            lblMatEst.AutoSize = true;
            lblMatEst.Location = new System.Drawing.Point(20, 23);
            lblMatEst.Name = "lblMatEst";
            lblMatEst.Size = new System.Drawing.Size(65, 15);
            lblMatEst.TabIndex = 0;
            lblMatEst.Text = "Estudiante:";
            // 
            // cmbMatEst
            // 
            cmbMatEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMatEst.FormattingEnabled = true;
            cmbMatEst.Location = new System.Drawing.Point(110, 20);
            cmbMatEst.Name = "cmbMatEst";
            cmbMatEst.Size = new System.Drawing.Size(280, 23);
            cmbMatEst.TabIndex = 0;
            // 
            // lblMatCurso
            // 
            lblMatCurso.AutoSize = true;
            lblMatCurso.Location = new System.Drawing.Point(20, 58);
            lblMatCurso.Name = "lblMatCurso";
            lblMatCurso.Size = new System.Drawing.Size(41, 15);
            lblMatCurso.TabIndex = 1;
            lblMatCurso.Text = "Curso:";
            // 
            // cmbMatCurso
            // 
            cmbMatCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMatCurso.FormattingEnabled = true;
            cmbMatCurso.Location = new System.Drawing.Point(110, 55);
            cmbMatCurso.Name = "cmbMatCurso";
            cmbMatCurso.Size = new System.Drawing.Size(280, 23);
            cmbMatCurso.TabIndex = 1;
            // 
            // btnMatricular
            // 
            btnMatricular.Location = new System.Drawing.Point(20, 95);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new System.Drawing.Size(150, 27);
            btnMatricular.TabIndex = 2;
            btnMatricular.Text = "Matricular";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // tabNotas
            // 
            tabNotas.BackColor = System.Drawing.Color.PaleTurquoise;
            tabNotas.Controls.Add(lblNotaEst);
            tabNotas.Controls.Add(cmbNotaEst);
            tabNotas.Controls.Add(lblNotaCurso);
            tabNotas.Controls.Add(cmbNotaCurso);
            tabNotas.Controls.Add(lblNota);
            tabNotas.Controls.Add(txtNota);
            tabNotas.Controls.Add(btnRegistrarNota);
            tabNotas.Location = new System.Drawing.Point(4, 24);
            tabNotas.Name = "tabNotas";
            tabNotas.Size = new System.Drawing.Size(536, 393);
            tabNotas.TabIndex = 3;
            tabNotas.Text = "Calificaciones";
            // 
            // lblNotaEst
            // 
            lblNotaEst.AutoSize = true;
            lblNotaEst.Location = new System.Drawing.Point(20, 23);
            lblNotaEst.Name = "lblNotaEst";
            lblNotaEst.Size = new System.Drawing.Size(65, 15);
            lblNotaEst.TabIndex = 0;
            lblNotaEst.Text = "Estudiante:";
            // 
            // cmbNotaEst
            // 
            cmbNotaEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbNotaEst.FormattingEnabled = true;
            cmbNotaEst.Location = new System.Drawing.Point(110, 20);
            cmbNotaEst.Name = "cmbNotaEst";
            cmbNotaEst.Size = new System.Drawing.Size(280, 23);
            cmbNotaEst.TabIndex = 0;
            // 
            // lblNotaCurso
            // 
            lblNotaCurso.AutoSize = true;
            lblNotaCurso.Location = new System.Drawing.Point(20, 58);
            lblNotaCurso.Name = "lblNotaCurso";
            lblNotaCurso.Size = new System.Drawing.Size(41, 15);
            lblNotaCurso.TabIndex = 1;
            lblNotaCurso.Text = "Curso:";
            // 
            // cmbNotaCurso
            // 
            cmbNotaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbNotaCurso.FormattingEnabled = true;
            cmbNotaCurso.Location = new System.Drawing.Point(110, 55);
            cmbNotaCurso.Name = "cmbNotaCurso";
            cmbNotaCurso.Size = new System.Drawing.Size(280, 23);
            cmbNotaCurso.TabIndex = 1;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new System.Drawing.Point(20, 93);
            lblNota.Name = "lblNota";
            lblNota.Size = new System.Drawing.Size(76, 15);
            lblNota.TabIndex = 2;
            lblNota.Text = "Nota (0-100):";
            // 
            // txtNota
            // 
            txtNota.Location = new System.Drawing.Point(110, 90);
            txtNota.Name = "txtNota";
            txtNota.Size = new System.Drawing.Size(80, 23);
            txtNota.TabIndex = 2;
            // 
            // btnRegistrarNota
            // 
            btnRegistrarNota.Location = new System.Drawing.Point(20, 130);
            btnRegistrarNota.Name = "btnRegistrarNota";
            btnRegistrarNota.Size = new System.Drawing.Size(150, 27);
            btnRegistrarNota.TabIndex = 3;
            btnRegistrarNota.Text = "Registrar nota";
            btnRegistrarNota.UseVisualStyleBackColor = true;
            btnRegistrarNota.Click += btnRegistrarNota_Click;
            // 
            // tabConsultas
            // 
            tabConsultas.BackColor = System.Drawing.Color.PaleTurquoise;
            tabConsultas.Controls.Add(lblConsEst);
            tabConsultas.Controls.Add(cmbConsEst);
            tabConsultas.Controls.Add(btnPromEst);
            tabConsultas.Controls.Add(btnInfo);
            tabConsultas.Controls.Add(lblConsCurso);
            tabConsultas.Controls.Add(cmbConsCurso);
            tabConsultas.Controls.Add(btnPromCurso);
            tabConsultas.Controls.Add(txtResultado);
            tabConsultas.Location = new System.Drawing.Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Size = new System.Drawing.Size(536, 393);
            tabConsultas.TabIndex = 4;
            tabConsultas.Text = "Consultas";
            // 
            // lblConsEst
            // 
            lblConsEst.AutoSize = true;
            lblConsEst.Location = new System.Drawing.Point(20, 23);
            lblConsEst.Name = "lblConsEst";
            lblConsEst.Size = new System.Drawing.Size(65, 15);
            lblConsEst.TabIndex = 0;
            lblConsEst.Text = "Estudiante:";
            // 
            // cmbConsEst
            // 
            cmbConsEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbConsEst.FormattingEnabled = true;
            cmbConsEst.Location = new System.Drawing.Point(110, 20);
            cmbConsEst.Name = "cmbConsEst";
            cmbConsEst.Size = new System.Drawing.Size(280, 23);
            cmbConsEst.TabIndex = 0;
            // 
            // btnPromEst
            // 
            btnPromEst.Location = new System.Drawing.Point(20, 55);
            btnPromEst.Name = "btnPromEst";
            btnPromEst.Size = new System.Drawing.Size(150, 27);
            btnPromEst.TabIndex = 1;
            btnPromEst.Text = "Promedio del estudiante";
            btnPromEst.UseVisualStyleBackColor = true;
            btnPromEst.Click += btnPromEst_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new System.Drawing.Point(180, 55);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(150, 27);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "Informacion academica";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // lblConsCurso
            // 
            lblConsCurso.AutoSize = true;
            lblConsCurso.Location = new System.Drawing.Point(20, 98);
            lblConsCurso.Name = "lblConsCurso";
            lblConsCurso.Size = new System.Drawing.Size(41, 15);
            lblConsCurso.TabIndex = 3;
            lblConsCurso.Text = "Curso:";
            // 
            // cmbConsCurso
            // 
            cmbConsCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbConsCurso.FormattingEnabled = true;
            cmbConsCurso.Location = new System.Drawing.Point(110, 95);
            cmbConsCurso.Name = "cmbConsCurso";
            cmbConsCurso.Size = new System.Drawing.Size(280, 23);
            cmbConsCurso.TabIndex = 3;
            // 
            // btnPromCurso
            // 
            btnPromCurso.Location = new System.Drawing.Point(20, 130);
            btnPromCurso.Name = "btnPromCurso";
            btnPromCurso.Size = new System.Drawing.Size(150, 27);
            btnPromCurso.TabIndex = 4;
            btnPromCurso.Text = "Promedio del curso";
            btnPromCurso.UseVisualStyleBackColor = true;
            btnPromCurso.Click += btnPromCurso_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new System.Drawing.Point(20, 170);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtResultado.Size = new System.Drawing.Size(496, 200);
            txtResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(544, 421);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion Academica";
            tabControl1.ResumeLayout(false);
            tabEstudiantes.ResumeLayout(false);
            tabEstudiantes.PerformLayout();
            tabCursos.ResumeLayout(false);
            tabCursos.PerformLayout();
            tabMatricula.ResumeLayout(false);
            tabMatricula.PerformLayout();
            tabNotas.ResumeLayout(false);
            tabNotas.PerformLayout();
            tabConsultas.ResumeLayout(false);
            tabConsultas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEstudiantes;
        private System.Windows.Forms.TabPage tabCursos;
        private System.Windows.Forms.TabPage tabMatricula;
        private System.Windows.Forms.TabPage tabNotas;
        private System.Windows.Forms.TabPage tabConsultas;

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombreEst;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombreEst;
        private System.Windows.Forms.Button btnRegistrarEstudiante;
        private System.Windows.Forms.ListBox lstEstudiantes;

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblCursosActivos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.ListBox lstCursosActivos;

        private System.Windows.Forms.Label lblMatEst;
        private System.Windows.Forms.Label lblMatCurso;
        private System.Windows.Forms.ComboBox cmbMatEst;
        private System.Windows.Forms.ComboBox cmbMatCurso;
        private System.Windows.Forms.Button btnMatricular;

        private System.Windows.Forms.Label lblNotaEst;
        private System.Windows.Forms.Label lblNotaCurso;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.ComboBox cmbNotaEst;
        private System.Windows.Forms.ComboBox cmbNotaCurso;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnRegistrarNota;

        private System.Windows.Forms.Label lblConsEst;
        private System.Windows.Forms.Label lblConsCurso;
        private System.Windows.Forms.ComboBox cmbConsEst;
        private System.Windows.Forms.ComboBox cmbConsCurso;
        private System.Windows.Forms.Button btnPromEst;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPromCurso;
        private System.Windows.Forms.TextBox txtResultado;
    }
}
