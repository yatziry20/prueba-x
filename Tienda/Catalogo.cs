using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Catalogo
    {
        private static List<Articulo> Inventario { get; set; }

        public static void LlenarCatalogo()
        {
            Inventario = new List<Articulo>
            {
                new Articulo{Nombre="jabon",Precio=18.9f, ID=1},
                new Articulo{Nombre="mayonesa",Precio=45.13f, ID=2},
                new Articulo{Nombre="tomate",Precio=49.00f, ID=3},
                new Articulo{Nombre="carne",Precio=98f, ID=4},
                new Articulo{Nombre="huevos",Precio=65f, ID=5},
                new Articulo{Nombre="coca cola",Precio=45f, ID=6},
                new Articulo{Nombre="maisoro",Precio=30.50f, ID=7},
                new Articulo{Nombre="papitas",Precio=20.21f, ID=8},
                new Articulo{Nombre="galletas",Precio=19.30f, ID=9},
                new Articulo{Nombre="agua mineral",Precio=24.23f, ID=10}
            };
        }
        public static void MostrarCatalogo()
        {
            LlenarCatalogo();
            foreach(Articulo art in Inventario)
            {
                Console.Write($"{art.ID} - {art.Nombre} - {art.Precio:C}\n");
            }
        }
        public static Articulo BuscarArticulosPorID(int artID)
        {
            return Inventario.Find(Articulo => Articulo.ID.Equals(artID));
            
        }
    }
}
