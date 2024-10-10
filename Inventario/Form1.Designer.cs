namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Sitka Banner", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(90, 96);
            button1.Name = "button1";
            button1.Size = new Size(251, 101);
            button1.TabIndex = 0;
            button1.Text = "Proveedores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("Sitka Banner", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(464, 96);
            button2.Name = "button2";
            button2.Size = new Size(251, 101);
            button2.TabIndex = 1;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Font = new Font("Sitka Banner", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(90, 237);
            button3.Name = "button3";
            button3.Size = new Size(251, 97);
            button3.TabIndex = 2;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 128);
            button4.Font = new Font("Sitka Banner", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(464, 237);
            button4.Name = "button4";
            button4.Size = new Size(251, 97);
            button4.TabIndex = 3;
            button4.Text = "Generar Reporte";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 255, 128);
            button5.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(90, 367);
            button5.Name = "button5";
            button5.Size = new Size(625, 49);
            button5.TabIndex = 4;
            button5.Text = "Actualizar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(192, 34);
            label1.Name = "label1";
            label1.Size = new Size(427, 47);
            label1.TabIndex = 5;
            label1.Text = "SISTEMA DE INVENTARIO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 428);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
