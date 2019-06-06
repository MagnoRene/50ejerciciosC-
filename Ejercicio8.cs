using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un algoritmo que imprima todos los números naturales que hay desde la unidad
            //hasta un número introducido por teclado
            int numero;
            Console.Write("Ingrese un numero donde desea finalizar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
