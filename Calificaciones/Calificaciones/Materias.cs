using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            CargarMaterias();
        }
        private void AgregarMateria_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia()
            {
                Nombre = MateriaNombre.Text,
                Codigo = MateriaCodigo.Text
            };

            Central.RegistrarMateria(materia);

            MateriaNombre.Clear();
            MateriaCodigo.Clear();
            MessageBox.Show("Materia registrada correctamente");

            CargarMaterias();
        }

        private void CargarMaterias()
        {

            List<Materia> materias = Central.ObtenerMaterias();

            ListaDeMaterias.Items.Clear();

            foreach (Materia materia in materias)
            {
                string displayText = $"{materia.Codigo} - {materia.Nombre}";
                ListaDeMaterias.Items.Add(displayText);
            }
        }
    }
}
