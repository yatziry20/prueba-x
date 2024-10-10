using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal abstract class Figura
    {
        protected double Area { get; set; }
        protected double Perimetro { get; set; }
        public string UnidadMedida { get; set; }

        public abstract void CalculaArea();
        public abstract void CalcularPerimetro();
        public void MuestraArea()
        {
            Console.WriteLine($"EL AREA ES {Area:F2} {UnidadMedida}");
        }
        public void MuestraPerimetro()
        {
            Console.WriteLine($"EL PERIMETRO ES {Perimetro:F2}{UnidadMedida}");
        }
    }
}
