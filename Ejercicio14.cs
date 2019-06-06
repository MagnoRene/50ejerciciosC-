using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular la suma de los cuadrados de los números pares entre el 0 y el 100.
            int suma;
            suma = 0;
            for (int i = 0; i <=100; i++)
            {
                if (i%2==0)
                {
                    suma = suma + (i*i);
                }
            }
            Console.WriteLine("Suma de los cuadrados de numeros pares es: {0}", suma);
            Console.ReadKey();

        }
    }
}
