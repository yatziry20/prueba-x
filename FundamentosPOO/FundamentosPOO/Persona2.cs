using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{ //hereda de clase persona
    class Persona2 : Persona
    {
        public Persona2( string nombre,string email,int id) 
        {
            Nombre = nombre;
            Email = email;
            ID = id;
            ImprimirNombre();
            ImprimeID();
            ImprimeEmail();
            ImprimeFecha();
        }
        public void ImprimeEmail()
        {
            Console.WriteLine(Email);
        }
        

    }
}
