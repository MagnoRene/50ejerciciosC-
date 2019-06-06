using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Hacer un algoritmo que imprima los números del 1 al 100 .que calcule la suma de
            //todos los números pares por un lado y otro la de todos los impares.
            int cantPares, cantimpares;
            cantPares = 0;
            cantimpares = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i%2==0)
                {
                    cantPares = cantPares + i;
                }
                else
                {
                    cantimpares = cantimpares + i;
                }
            }            Console.WriteLine("Suma de numeros PARES: {0}", cantPares);            Console.WriteLine("Suma de numeros IMPARES: {0}", cantimpares);            Console.ReadKey();
        }
    }
}
