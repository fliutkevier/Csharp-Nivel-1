﻿using System;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                resultado = n1 - n2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
            }else if(n1 == n2)
            {
                resultado = n1 + n2;
                Console.WriteLine("El resultado de la suma es: " + resultado);
            }else
            {
                resultado = n1 * n2;
                Console.WriteLine("El resultado del producto es: " + resultado);
            }
        }
    }
}
