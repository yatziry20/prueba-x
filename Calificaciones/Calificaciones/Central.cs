using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Central
    {
        private static List<Alumno> alumnos = new List<Alumno>();
        private static List<Materia> materias = new List<Materia>();
        public static void RegistrarAlumno(Alumno alumno)
        {
            if (alumno != null && !string.IsNullOrEmpty(alumno.Matricula))
            {
                alumnos.Add(alumno);
            }

        }
        public static List<Alumno> ObtenerAlumnos()
        {
            return alumnos;
        }

        // Eliminar Alumno por matrícula
        public static void EliminarAlumno(string matricula)
        {
            Alumno alumnoAEliminar = alumnos.FirstOrDefault(a => a.Matricula == matricula);
            if (alumnoAEliminar != null)
            {
                alumnos.Remove(alumnoAEliminar);
            }
        }

        // Registrar Materia
        public static void RegistrarMateria(Materia materia)
        {
            if (materia != null && !string.IsNullOrEmpty(materia.Codigo))
            {
                materias.Add(materia);
            }
        }

        // Obtener todas las Materias
        public static List<Materia> ObtenerMaterias()
        {
            return materias;
        }

        // Eliminar Materia por código
        public static void EliminarMateria(string codigo)
        {
            Materia materiaAEliminar = materias.FirstOrDefault(m => m.Codigo == codigo);
            if (materiaAEliminar != null)
            {
                materias.Remove(materiaAEliminar);
            }
        }

    }
}
