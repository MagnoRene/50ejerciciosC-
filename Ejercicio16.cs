using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un numero por teclado que nos diga si es positivo o negativo
            int numero;
            numero = 0;
            Console.Write("Ingrese un Número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("Numero Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Numero Negativo");
            }
            else
            {
                Console.WriteLine("El numero es NEUTRO");
            }
            Console.ReadKey();
        }
    }
}
