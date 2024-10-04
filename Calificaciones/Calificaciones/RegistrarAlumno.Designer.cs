namespace Calificaciones
{
    partial class RegistrarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Registrar = new Button();
            Nombre = new Label();
            Apellido = new Label();
            Matricula = new Label();
            nombreAlumno = new TextBox();
            ApellidoAlumno = new TextBox();
            MatriculaAlumno = new TextBox();
            SuspendLayout();
            // 
            // Registrar
            // 
            Registrar.Location = new Point(86, 214);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(75, 23);
            Registrar.TabIndex = 0;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(23, 23);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(23, 74);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(51, 15);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Location = new Point(23, 130);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(57, 15);
            Matricula.TabIndex = 3;
            Matricula.Text = "Matricula";
            // 
            // nombreAlumno
            // 
            nombreAlumno.Location = new Point(86, 23);
            nombreAlumno.Name = "nombreAlumno";
            nombreAlumno.Size = new Size(100, 23);
            nombreAlumno.TabIndex = 4;

            // 
            // ApellidoAlumno
            // 
            ApellidoAlumno.Location = new Point(86, 74);
            ApellidoAlumno.Name = "ApellidoAlumno";
            ApellidoAlumno.Size = new Size(100, 23);
            ApellidoAlumno.TabIndex = 5;
            // 
            // MatriculaAlumno
            // 
            MatriculaAlumno.Location = new Point(86, 127);
            MatriculaAlumno.Name = "MatriculaAlumno";
            MatriculaAlumno.Size = new Size(100, 23);
            MatriculaAlumno.TabIndex = 6;
            // 
            // RegistrarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 284);
            Controls.Add(MatriculaAlumno);
            Controls.Add(ApellidoAlumno);
            Controls.Add(nombreAlumno);
            Controls.Add(Matricula);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Registrar);
            Name = "RegistrarAlumno";
            Text = "RegistrarAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registrar;
        private Label Nombre;
        private Label Apellido;
        private Label Matricula;
        private TextBox nombreAlumno;
        private TextBox ApellidoAlumno;
        private TextBox MatriculaAlumno;
    }
}