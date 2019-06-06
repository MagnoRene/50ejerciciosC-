using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            suma = 0;
            // Hacer un algoritmo que imprima los números impares desde el 100 hasta la unidad y que calcule su suma
            for (int i =100; i >=1; i--)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                    suma = suma + i;
                }
            }
            Console.WriteLine("Suma de numeros impares: {0}", suma);
            Console.ReadKey();
        }
    }
}
