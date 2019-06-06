using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un numero por teclado menor que 100.imprimir la suma de
            //los cuadrados de los números que están separados entre si 4 posiciones.
            int numero, suma;
            numero = 0;
            suma = 0;
            Console.Write("Introduce un numero menor que 100:");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero>100)
            {
                Console.Write("No es un numero menor que 100");
            }
            else
            {
                for (int i = numero; i <= 100; i = i + 4)
                {
                    suma = suma + (i * i);
                }
            }
            Console.Write("Suma de los cuadrados de los numeros separados 4 posiciones: {0}", suma);
            Console.ReadKey();
        }
    }
}
