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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();

        }
        private void CargarAlumnos()
        {
            List<Alumno> alumnos = Central.ObtenerAlumnos();

            ListaAlumnos.Items.Clear();

            foreach (Alumno alumno in alumnos)
            {

                string displayText = $"{alumno.Matricula} - {alumno.Nombre} {alumno.Apellidos}";
                ListaAlumnos.Items.Add(displayText);
            }
        }

        private void AgregarAlumno(object sender, EventArgs e)
        {
           
            CargarAlumnos();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            RegistrarAlumno reg = new RegistrarAlumno();
            reg.Show();


            CargarAlumnos();
        }
    }

}
