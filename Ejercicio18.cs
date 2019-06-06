using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir y contar los múltiplos de 3 desde la unidad hasta un número que introducimos por teclado
            int numero,cantidad;
            numero = 0;
            cantidad = 0;
            Console.Write("Ingrese el numero donde desea Finalizar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < numero; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                    cantidad = cantidad + 1;
                }
            }
            Console.WriteLine("Cantidad de multiplos de 3 encontrados: {0} ",cantidad);
            Console.ReadKey();
            
        }
    }
}
