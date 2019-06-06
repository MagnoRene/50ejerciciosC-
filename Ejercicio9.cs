using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un algoritmo que calcula la suma de los números impares
            //comprendidos entre el 0 y 100
            int suma;
            suma = 0;
            for (int i = 0; i <=100; i++)
            {
                if (i%2!=0)
                {
                    suma = suma + i;
                }
            }
            Console.WriteLine("Total de la suma de numeros impares del 0 al 100: {0}",suma);
            Console.ReadKey();
        }
    }
}
