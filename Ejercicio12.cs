using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir, contar y sumar los múltiplos de 10 hasta un número que
            //introducimos por teclado
            int num, cantidad, suma;
            cantidad = 0;
            suma = 0;
            num = 0;
            Console.Write("Ingrese un numero donde desea finalizar: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                    cantidad = cantidad + 1;
                    suma = suma + i;
                }
            }
            Console.WriteLine("Multiplos de 10 encontrado: {0} ", cantidad);
            Console.WriteLine("Suma total de los multiplos: {0}", suma);
            Console.ReadKey();
        }
    }
}
