namespace Calificaciones
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("MS PGothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(150, 84);
            button1.TabIndex = 0;
            button1.Text = "VerAlumnos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Font = new Font("MS PGothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(178, 97);
            button2.Name = "button2";
            button2.Size = new Size(137, 84);
            button2.TabIndex = 1;
            button2.Text = "VerMaterias";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(50, 43);
            label1.Name = "label1";
            label1.Size = new Size(236, 20);
            label1.TabIndex = 2;
            label1.Text = "¿QUE DESEA VER?";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(340, 223);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Goudy Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Info;
            Name = "Form1";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}