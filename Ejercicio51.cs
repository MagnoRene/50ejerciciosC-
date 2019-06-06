using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que lea dos enteros y que determine e imprima si el primero es multiplo del segundo

            int n1 = 0, n2 = 0;
            Console .Write("Ingrese el primer valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console .Write("Ingrese el segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 % n1 == 0)
            {
                Console .WriteLine("El primer número leídos es múltiplo del segundo");
            }
            else
            {
                Console .WriteLine("No es múltiplo del segundo número leído");
            }
            Console.ReadKey();

        }
    }
}
