using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un número por teclado menor que 500.Imprimir, sumar y contar los números
            //que estan separado entre si 8 posiciones, desde ese numero al 500
            int numero, suma, cantidad;
            numero = 0;
            suma = 0;
            cantidad = 0;
            Console.Write("Ingrese un numero menor que 500: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >=500)
            {
                Console.Write("El numero ingresado es mayor a 500.");
            }
            else
            {
                for (int i =numero; i <=500; i=i+8)
                {
                    Console.WriteLine(i);
                    suma = suma + i;
                    cantidad = cantidad + 1;                                       
                }
            }
            Console.WriteLine("Suma de los numeros en 8 posiciones: {0}", suma);
            Console.WriteLine("cantidad de numeros en 8 posiciones: {0}", cantidad);
            Console.ReadKey();
        }
    }
}
