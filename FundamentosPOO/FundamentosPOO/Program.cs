using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        //TAREA 
        //investigar las clases abstractas con ejemplo
        static void Main(string[] args)
        {
            Persona2 persona2 = new Persona2("juan", "Juanito@email.com", 1);
            Console.ReadLine();
            persona2.Nombre = "juan juanito";
            persona2.Email = "Juanitojuan@Email.com";
            persona2.ImprimirNombre();
            persona2.ImprimeEmail();
            persona2.CambiarFecha(DateTime.Now);
            persona2.ImprimeFecha();
            Console.ReadLine();

        }
    }
}
