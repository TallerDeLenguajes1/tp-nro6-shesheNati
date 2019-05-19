using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_6
{
    class Program
    {

        static void Main(string[] args)
        {
            //punto 1 
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Invertir(num));
            Console.ReadKey();


        }

        static int Invertir(int num)
        {
            int resto;
            int invertido = 0;

            if (num > 0)
            {
                while(num > 0)
            {
                    resto = num % 10;
                    num /= 10;
                    invertido = (invertido * 10) + resto;
                }
                return invertido;
            }
            else
            {
                return num;
            }
            
        }

    }
}
