using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();
            bool continuar = true;
            while (continuar) 
            {
                string nombre = "";
                int cantidad = 0;
                decimal precio = 0;
                Console.WriteLine("ingresa el nombre del producto");
                nombre = Console.ReadLine();
                Console.WriteLine("ingresa la cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa el precio");
                precio = Convert.ToDecimal(Console.ReadLine());

                if (continuar)
                {
                    Console.WriteLine("Desea realizar otra operacion?");
                    Console.WriteLine("S- SI");
                    Console.WriteLine("N- NO");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                    Console.Clear();
                }
            
                Producto prod = new Producto();
                prod.Nombre = nombre;
                prod.Cantidad = cantidad;
                prod.Precio = precio;

                carrito.AgregarProducto(prod);

                 Caja caja = new Caja();
                caja.Cobrar(carrito);
                //Producto prod2 = new Producto();
                //prod2.Nombre = nombre;
                //prod2.Cantidad = cantidad;
                //prod2.Precio = precio;
                carrito.MostrarCarrito();
                Console.ReadLine();
            }
        }
    }
}
