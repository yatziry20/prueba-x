using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    internal class Carrito
    {
        public List<Producto> lista { get; set; } = new List<Producto>();
        public void AgregarProducto( Producto producto)
        {
            lista.Add(producto);
        }
        public void MostrarCarrito()
        {
            for (int p = 0 ; p < lista.Count; p++)
            {
                Console.WriteLine($"Nombre:{lista[p].Nombre}." + 
                    $"Cantidad: {lista[p].Cantidad}." + 
                    $"Precio: {lista[p].Precio:C}." + 
                    $"total: {lista[p].Cantidad * lista[p].Precio:C}.");
            }
        }
    }
}
