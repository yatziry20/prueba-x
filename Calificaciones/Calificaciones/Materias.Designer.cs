namespace Calificaciones
{
    partial class Materias
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
            AgregarMateria = new Button();
            ListaDeMaterias = new ListBox();
            MateriaNombre = new TextBox();
            MateriaCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // AgregarMateria
            // 
            AgregarMateria.BackColor = Color.Violet;
            AgregarMateria.Font = new Font("MS PGothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AgregarMateria.Location = new Point(146, 164);
            AgregarMateria.Name = "AgregarMateria";
            AgregarMateria.Size = new Size(185, 37);
            AgregarMateria.TabIndex = 0;
            AgregarMateria.Text = "AgregarMateria";
            AgregarMateria.UseVisualStyleBackColor = false;
            AgregarMateria.Click += AgregarMateria_Click;
            // 
            // ListaDeMaterias
            // 
            ListaDeMaterias.BackColor = Color.Plum;
            ListaDeMaterias.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ListaDeMaterias.FormattingEnabled = true;
            ListaDeMaterias.ItemHeight = 27;
            ListaDeMaterias.Location = new Point(53, 207);
            ListaDeMaterias.Name = "ListaDeMaterias";
            ListaDeMaterias.Size = new Size(382, 85);
            ListaDeMaterias.TabIndex = 1;
            // 
            // MateriaNombre
            // 
            MateriaNombre.BackColor = Color.Plum;
            MateriaNombre.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MateriaNombre.Location = new Point(78, 52);
            MateriaNombre.Name = "MateriaNombre";
            MateriaNombre.Size = new Size(336, 23);
            MateriaNombre.TabIndex = 2;
            // 
            // MateriaCodigo
            // 
            MateriaCodigo.BackColor = Color.Plum;
            MateriaCodigo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            MateriaCodigo.Location = new Point(116, 125);
            MateriaCodigo.Name = "MateriaCodigo";
            MateriaCodigo.Size = new Size(247, 23);
            MateriaCodigo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(78, 27);
            label1.Name = "label1";
            label1.Size = new Size(336, 22);
            label1.TabIndex = 4;
            label1.Text = "Nombre_De_Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Goudy Stout", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(78, 100);
            label2.Name = "label2";
            label2.Size = new Size(319, 22);
            label2.TabIndex = 5;
            label2.Text = "Codigo_De_Materia";
            // 
            // Materias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(486, 304);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MateriaCodigo);
            Controls.Add(MateriaNombre);
            Controls.Add(ListaDeMaterias);
            Controls.Add(AgregarMateria);
            ForeColor = SystemColors.ControlText;
            Name = "Materias";
            Text = "Materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgregarMateria;
        private ListBox ListaDeMaterias;
        private TextBox MateriaNombre;
        private TextBox MateriaCodigo;
        private Label label1;
        private Label label2;
    }
}