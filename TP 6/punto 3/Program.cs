using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                    ***___CALCULADORA ___***");
            Console.WriteLine("");
            Console.WriteLine("     Elija una operacion a utilizar");

            Console.Title = "Calculadora muy Cientifica"; //sirve p/ agregarle un titulo a la ventana
            string resp = "";



            bool exit = false;
            while (!exit)
            {
                Menu();
                int operacion;
                operacion = int.Parse(Console.ReadLine());
                switch (operacion)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Resta();
                        break;
                    case 3 :
                        Multiplicacion();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5 :
                        ValorAbsoluto();
                        break;
                    case 6 :
                        AlCuadrado();
                        break;
                    case 7:
                        RaizCuadrada();
                        break;
                    case 8:
                        Seno();
                        break;
                    case 9:
                        Coseno();
                        break;
                    case 10:
                        ParteEntera();
                        break;
                    case 11:
                    case 0:
                        MaxMin();
                        break;
                        Console.Write("¿Esta seguro que desea salir? si/no:(1 es si y 0 es no) "); //Si para realizarlo de nuevo y no para salir.
                        resp = Console.ReadLine();
                        if (resp == "1")
                        {
                            exit = true;
                        }

                        break;
                    default:
                        Console.WriteLine("     Ingreso una opcion de operacion incorrecta.");
                        break;
                }
            }

        }


        static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("     1   Sumar");
            Console.WriteLine("     2   Restar");
            Console.WriteLine("     3   Multiplicar");
            Console.WriteLine("     4   Dividir");
            Console.WriteLine("     5   Valor absoluto");
            Console.WriteLine("     6   El cuadrado");
            Console.WriteLine("     7   La raiz cuadrada");
            Console.WriteLine("     8   Seno");
            Console.WriteLine("     9   Coseno");
            Console.WriteLine("     10  Parte entera de un tipo float");
            Console.WriteLine("     0   Salir");
        }
        static void Suma()
        {
            int n1, n2;
            Console.WriteLine("     Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("     Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("     El resultado de la suma es: " + (n1 + n2));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();
        }

        static void Resta()
        {
            int n1, n2;
            Console.WriteLine("     Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("     Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("     El resultado de la resta es: " + (n1 - n2));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }

        static void Multiplicacion()
        {
            int n1, n2;
            Console.WriteLine("     Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("     Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("     El resultado de la multipliacion es: " + (n1 * n2));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }
        static void Division()
        {
            float n1, n2;
            Console.WriteLine("     Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("     Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("     El resultado de la division es: " + (n1 / n2));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }
        static void ValorAbsoluto()
        {
            int n;
            Console.WriteLine("     Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("     El valor absoluto de un numero es " + Math.Abs(n));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }

        static void AlCuadrado()
        {
            int n;
            Console.WriteLine("     Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("     El cuadrado de un numero  es: " + Math.Pow(n,2));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }

        static void RaizCuadrada()
        {
            int n;
            Console.WriteLine("     Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("     La raiz cuadrada de un numero es: " + Math.Sqrt(n));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }
        static void Seno()
        {
            int n;
            Console.WriteLine("     Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("     El seno de un numero es: " + Math.Sin(n));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }
        static void Coseno()
        {
            int n;
            Console.WriteLine("     Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("     El coseno de un numero es: " + Math.Cos(n));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }
        static void ParteEntera()
        {
            float n;
            Console.WriteLine("     Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("     La parte entera de un float es: " + Math.Truncate(n));
            Console.WriteLine("");
            Console.WriteLine("     Presione una tecla para continuar");

            Console.ReadKey();

        }
        static void MaxMin()
        {
            int n1, n2;
            Console.WriteLine("Calculamos el maximo y minimo entre dos numeros");
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El maximo entre dos numeros:" + n1 +"y"+ n2 + "es: " + Math.Max(n1,n2));
            Console.WriteLine("El minimo entre dos numeros:" + n1 + "y" + n2 + "es: " + Math.Min(n1, n2));
        }
    }
}
