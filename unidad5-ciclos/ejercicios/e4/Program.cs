using System;

namespace e4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            /*int n;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            if ((n % n == 0) && (n / 1 == n))
            {
                Console.WriteLine("El número " + n + " es primo.");
            }else
            {
                Console.WriteLine("El número no es primo.");
            }
            */

            //CORRECCIÓN¿
            int n, con = 0;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (n % i == 0)
                {
                    con++;
                }
            }
            if (con == 0)
            {
                Console.WriteLine("El número es primo.");
            }else
            {
                Console.WriteLine("El número NO es primo.");
            }
        }
    }
}
