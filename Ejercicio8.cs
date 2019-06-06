using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            cantidad = 0;
            //Hacer un algoritmo que imprima y cuente los múltiplos de 3 que hay entre 1 y 100
            for (int i = 1; i <= 100; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                    cantidad = cantidad + 1;
                }
            }
            Console.WriteLine("Total de multiplos de 3 encontrados: {0} ",cantidad);
            Console.ReadKey();
        }
    }
}
