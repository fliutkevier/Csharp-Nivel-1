using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n, con = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                if (par(n))
                {
                    con++;
                }
            }
            
            Console.WriteLine("Hay " + con + " números pares.");
        }

        static bool par (int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
