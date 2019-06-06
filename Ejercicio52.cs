using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que calcule los cuadrados y los cubos de los números del 1 al 10,
            //imprimiendolos en la siguiente forma.

            int c = 0;
            Console.WriteLine("Número           Cuadrado            Cubo");
            while (c < 10)
            {
                c++;
                Console.Write("\n");
                Console.Write("    " + c);
                Console.Write("\t\t   " + (c * c));
                Console.Write("\t\t\t" + c * c * c);

            }
            Console.ReadKey();
        }
        }
}
