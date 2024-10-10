using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Circulo : Figura
    {
        public double Radio { get; set; }
        public double Pi { get; set; } = Math.PI;
        public override void CalculaArea()
        {
            Area = (Radio * Radio) * Pi ;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 2 * Pi * Radio;
        }
    }
}
