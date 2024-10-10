using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Triangulo : Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Lado { get; set; }
        public override void CalculaArea()
        {
            Area = (Base * Altura) / 2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 3;
        }
    }
}
