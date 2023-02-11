using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // paso 0
            // tipo de dato: int, float, char, bool.
            int n1, n2, resultado;

            n1 = 7;
            n2 = 9;

            // paso 1: pedir valores.
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());

            // paso 2: realizar cálculo.
            //+ - * / %
            resultado = n1 + n2;

            // paso 3: emitir resultado.
            Console.WriteLine("El resultado es: " + resultado);

            //float precio;
            //precio = 12.32F;
        }
    }
}
