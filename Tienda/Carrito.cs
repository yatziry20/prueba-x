using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Carrito
    {
        public List<Articulo> lista { get; set; } = new List<Articulo>();
        public void AgregarArticulo(Articulo articulo)
        {
            lista.Add(articulo);
        }

        public void MostrarArticulosEnCarrito()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
            }
            else
            {
                foreach (var articulo in lista)
                {
                    Console.WriteLine($"ID: {articulo.ID}," +
                        $" Nombre: {articulo.Nombre}," +
                        $" Precio: {articulo.Precio}");
                }
            }
        }
    }
}
