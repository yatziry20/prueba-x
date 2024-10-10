using FundamentosPOO.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        //TAREA 
        //investigar las clases abstractas con ejemplo
        static void Main(string[] args)
        {
            //Persona2 persona2 = new Persona2("juan", "Juanito@email.com", 1);
            //Console.ReadLine();
            //persona2.Nombre = "juan juanito";
            //persona2.Email = "Juanitojuan@Email.com";
            //persona2.ImprimirNombre();
            //persona2.ImprimeEmail();
            //persona2.CambiarFecha(DateTime.Now);
            //persona2.ImprimeFecha();




            // inmplementar el triangulo,circulo rectangulo y el poligono

            Console.WriteLine("-----------------Cuadrado-----------------");

            Cuadrado cuadrado = new Cuadrado()
            {
                MedidaLado = 5,
                UnidadMedida = "cm"
            };
            cuadrado.CalculaArea();
            cuadrado.CalcularPerimetro();
            cuadrado.MuestraArea();
            cuadrado.MuestraPerimetro();

            Console.WriteLine("-----------------Triangulo-----------------");

            Triangulo triangulo = new Triangulo()
            {
                Base = 5,
                Altura = 10,
                Lado = 15,
                UnidadMedida = "cm"
            };
            triangulo.CalculaArea();
            triangulo.CalcularPerimetro();
            triangulo.MuestraArea();
            triangulo.MuestraPerimetro();

            Console.WriteLine("-----------------Circulo-----------------");

            Circulo circulo = new Circulo()
            {
                Radio = 5,
                UnidadMedida = "cm"
            };

            circulo.CalculaArea();
            circulo.CalcularPerimetro();
            circulo.MuestraArea();
            circulo.MuestraPerimetro();

            Console.WriteLine("-----------------Rectangulo-----------------");

            Rectangulo rectangulo = new Rectangulo()
            {
                largo = 5,
                Ancho = 10,
                UnidadMedida = "cm"
            };
            rectangulo.CalculaArea();
            rectangulo.CalcularPerimetro();
            rectangulo.MuestraArea();
            rectangulo.MuestraPerimetro();

            Console.WriteLine("-----------------Poligono-----------------");

            Poligono poligono = new Poligono()
            {
                Ladito = 5,
                Apotema = 4.4,
                NumeroLados = 5,
                UnidadMedida = "cm"
            };
            poligono.CalcularPerimetro();
            poligono.CalculaArea();
            poligono.MuestraArea();
            poligono.MuestraPerimetro();


            Console.ReadLine();
        }
    }
}
