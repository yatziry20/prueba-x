namespace Prueba_semana_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            int resultado = suma(num1, num2);
        }

        private int suma(int a, int b)
        {
            return a + b;
        }
    }
}
