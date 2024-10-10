﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Cuadrado : Figura
    {
        public int MedidaLado { get; set; }

        public override void CalculaArea()
        {
            Area = MedidaLado * MedidaLado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = MedidaLado * 4;
        }
    }
}
