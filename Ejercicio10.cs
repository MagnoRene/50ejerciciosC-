using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que imprima y cuente los múltiplos de 5 que hay entre 1 y 500
            int cantidad;
            cantidad = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i%5==0)
                {
                    Console.WriteLine(i);
                    cantidad = cantidad + 1;
                }
            }
            Console.WriteLine("Cantidad de multiplos de 5 entre 1 al 500:  {0}", cantidad);
            Console.ReadKey();
        }
    }
}
