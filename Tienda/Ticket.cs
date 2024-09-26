using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    //o Lista de artículos
    //o IVA
    //o Total, pagado y cambio
    //o Fecha
    //o Numero de compra

    internal class Ticket
    {
        public List<Articulo> Inventario { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public decimal Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCompra { get; set; }
        public decimal IVA { get; set; }
    }
}
