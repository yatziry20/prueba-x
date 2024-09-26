using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();

            while (true)
            {
                Console.WriteLine("Selecciona el articulo:");
                Catalogo.MostrarCatalogo();
                int artID = Convert.ToInt32(Console.ReadLine());
                Articulo articuloSeleccionado = Catalogo.BuscarArticulosPorID(artID);

                if (articuloSeleccionado != null)
                {
                    carrito.AgregarArticulo(articuloSeleccionado);
                    Console.WriteLine($"{articuloSeleccionado.Nombre} agregado al carrito.\n");
                }
                Console.ReadLine();
            }
        }
    }
}
