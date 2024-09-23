using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("-------------Que desea hacer?-------------");
                Console.WriteLine("0- Salir");
                Console.WriteLine("1- Validar numeros primos");
                Console.WriteLine("2- Validar numero mayor y numero menor");
                Console.WriteLine("3- Numero mayor de una lista");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1:
                        NumerosPirmos();
                        break;
                    case 2:
                        NumeroMayorNUmeroMenor();
                        break;
                    case 3:
                        MayorDeUnaLista();
                        break;
                }
                if (continuar)
                {
                    Console.WriteLine("Desea realizar otra operacion?");
                    Console.WriteLine("S- SI");
                    Console.WriteLine("N- NO");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
        private static void NumerosPirmos()
        {
            int n = 0;
            Console.WriteLine("Dame un numero mayor a 1");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Numero no valido");
            }
            for (int i = 2; i <= n; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine($"{i} es primo");
                }
            }
            Console.WriteLine();
        }

        private static bool EsPrimo(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void NumeroMayorNUmeroMenor()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Dame el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            NumeroMayor(num1, num2, num3);
            NumeroMenor(num1, num2, num3);
        }
        private static void NumeroMayor(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"el numero {num1} es el mayor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el mayor");
                }

            }
            else if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("el segundo numero es el mayor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el mayor");
                }
            }

        }

        private static void NumeroMenor(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("el perimer numero es el menor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el menor");
                }

            }
            else if (num2 < num1)
            {
                if (num2 < num3)
                {
                    Console.WriteLine("el segundo numero es el menor");
                }
                else
                {
                    Console.WriteLine("el tercer numero es el menor");
                }
            }
        }
        private static void MayorDeUnaLista()
        {
            bool continuar = false;
            List<int> list = new List<int>();
            while (continuar)
            {
                Console.WriteLine("Escribe un numero");

            }

        }
    }
}