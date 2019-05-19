using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                    ***___CALCULADORA BASICA___***");
            Console.WriteLine("");
            Console.WriteLine("     Elija el simbolo con la operacion a utilizar");

            Console.Title = "Calculadora Cientifica"; //sirve p/ agregarle un titulo a la ventana
            string resp = "";



            bool exit = false;
            while (!exit)
            {
                Menu();
                string simbolo = (Console.ReadLine());
                switch (simbolo)
                {
                    case "+":
                        Suma();
                        break;
                    case "-":
                        Resta();
                        break;
                    case "*":
                        Multiplicacion();
                        break;
                    case "/":
                        Division();
                        break;
                    case "q":
                        Console.Write("¿Esta seguro que desea salir? si/no: "); //Si para realizarlo de nuevo y no para salir.
                        resp = Console.ReadLine();
                        if (resp == "si" || resp == "s" || resp == "y")
                        {
                            exit = true;
                        }

                        break;
                    default:
                        Console.WriteLine("     Ingreso un simbolo incorrecto.");
                        break;
                }
            }

        }


        static void Menu()
        { 
            Console.WriteLine("");
            Console.WriteLine("     +   (Sumar)");
            Console.WriteLine("     -   (Restar)");
            Console.WriteLine("     *   (Multiplicar)");
            Console.WriteLine("     /   (Dividir)");
            Console.WriteLine("     q   (Salir)");
        }
        static void Suma()
        {
            int n1, n2;
            Console.WriteLine("     Ingrese un numero");
            n1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("     Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine()) ;
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

    }
}
