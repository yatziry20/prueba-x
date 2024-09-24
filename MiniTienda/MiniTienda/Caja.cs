using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    class Caja
    {
        public void Cobrar(Carrito carrito)
        {
            decimal total = 0;

            // foreach es para recorrer cada elemento de una lista 
            foreach (Producto producto in carrito.lista)
            {
                total += producto.Cantidad * producto.Precio;  // Multiplicar cantidad por precio
            }

            Console.WriteLine($"El total a pagar es: {total:C}");
        }

    }

}
