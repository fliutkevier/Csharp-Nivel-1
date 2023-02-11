using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            //primer número
            Console.WriteLine("Introduzca un número: ");
            n1 = int.Parse(Console.ReadLine());
            //segundo número
            Console.WriteLine("Introduzca otro número: ");
            n2 = int.Parse(Console.ReadLine());
            //calculo y resultado
            resultado = n1 + n2;
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}