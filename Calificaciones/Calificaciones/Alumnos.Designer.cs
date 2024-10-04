namespace Calificaciones
{
    partial class Alumnos
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
            ListaAlumnos = new ListBox();
            SuspendLayout();
            // 
            // Registrar
            // 
            Registrar.Location = new Point(135, 24);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(146, 28);
            Registrar.TabIndex = 0;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // ListaAlumnos
            // 
            ListaAlumnos.FormattingEnabled = true;
            ListaAlumnos.ItemHeight = 15;
            ListaAlumnos.Location = new Point(45, 68);
            ListaAlumnos.Name = "ListaAlumnos";
            ListaAlumnos.Size = new Size(353, 124);
            ListaAlumnos.TabIndex = 1;
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 217);
            Controls.Add(ListaAlumnos);
            Controls.Add(Registrar);
            Name = "Alumnos";
            Text = "Alumnos";
            ResumeLayout(false);
        }

        #endregion

        private Button Registrar;
        private ListBox ListaAlumnos;
    }
}