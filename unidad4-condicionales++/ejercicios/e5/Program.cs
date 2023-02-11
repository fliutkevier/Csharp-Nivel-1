using System;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
            //decreciente = de mayor a menor
            int a, b, c, d;
            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número:");
            d = int.Parse(Console.ReadLine());

            if (a > b && b > c && c > d)
            {
                Console.WriteLine("Están ordenados de forma decreciente.");
            }else
            {
                Console.WriteLine("No están ordenados de forma decreciente.");
            }
        }
    }
}
