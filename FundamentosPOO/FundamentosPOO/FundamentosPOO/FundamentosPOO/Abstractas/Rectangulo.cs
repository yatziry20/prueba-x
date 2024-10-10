using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Rectangulo : Figura
    {
        public int largo { get; set; }
        public int Ancho { get; set; }
        public override void CalculaArea()
        {
            Area = largo * Ancho;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = (largo * 2) * (Ancho * 2);
        }
    }
}
