using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Poligono : Figura
    {
        public double Apotema { get; set; }

        public double Ladito { get; set; }
        public int NumeroLados { get; set; }

        public override void CalcularPerimetro()
        {
            Perimetro = Ladito * NumeroLados;
        }
        public override void CalculaArea()
        {
            Area = (Apotema * Perimetro) / 2;
        }
    }
}
