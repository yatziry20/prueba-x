namespace Prueba_semana_1
{
    public partial class Form1 : Form
    {  
        // -----------------------------TAREA-------------------------------------
        // Realizar las operaciones matematicas restantes (resta, multiplicacion y divicion)
        // Crear otra clase aparte en la que se realice las sentencias de control  y que
        // hagan uso de los operadores relacionales y logicos
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            operaciones op = new operaciones();
            int resultadosum = op.suma(num1, num2);
            int resultadorest = op.resta(num1, num2);
            int resultadomulti = op.multiplicacion(num1, num2);
            int resultadodivi = op.divicion(num1, num2);
        }
    }
    class operaciones
    {
        public int suma(int a, int b)
        {
            return a + b;
        }
        public int resta(int a, int b)
        {
            return a - b;
        }
        public int multiplicacion(int a, int b)
        {
            return a * b;
        }
        public int divicion(int a, int b)
        {
            return a / b;
        }
    }
    class Sentencias_De_Control
    {
        public void EvaluarEdad()
        {
            int Edad = 20;

            if (Edad > 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else if (Edad > 60)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Ya eres de la tercera edad");
            }
        }
        public void Meses()
        {
            int mes = 8;
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("ese mes no existe");
                    break;
            }
        }
        public void Break_y_continue()
        {
            for (int i = 0; i < 8; i++)
            {
                if (i == 6)
                {
                    break; //este detiene
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue; // este continua
                }
                Console.WriteLine(i);
            }
        }
    }
}

