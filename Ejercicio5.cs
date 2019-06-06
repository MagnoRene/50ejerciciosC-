using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un algoritmo que imprima los números impares hasta el 100 y que imprima cuantos impares hay
            int cantidad;
            cantidad = 0;
            for (int i=1; i <=100; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                    cantidad = cantidad + 1;
                }
            }            Console.Write("Numeros Impares encontrado {0}",cantidad);            Console.ReadKey();
        }
    }
}
