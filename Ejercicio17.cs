﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introducir un número por teclado. Que nos diga si es par o impar.
            int numero;
            numero = 0;
            Console.Write("Ingrese un Número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero%2==0)
            {
                Console.WriteLine("El Numero ingresado es PAR");
            }
            else
            {
                Console.WriteLine("El Numero ingresado es IMPAR");
            }
            Console.ReadKey();
        }
    }
}
