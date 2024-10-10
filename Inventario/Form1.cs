namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

    }
}
