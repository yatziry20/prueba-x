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
    public partial class RegistrarAlumno : Form
    {
        public RegistrarAlumno()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = nombreAlumno.Text;
            alumno.Apellidos = ApellidoAlumno.Text;
            alumno.Matricula = MatriculaAlumno.Text;

            Central.RegistrarAlumno(alumno);
        }
    }
}
