using System;

namespace TPFinal_Liutkevier
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            a. El mayor de los números pares.
            b. La cantidad de números impares.
            c. El menor de los números primos.

            Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            */

            int n, conImpares = 0;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            int mayorPares = n;
            int menorPrimo = n;

            while (n != 0)
            {
                //Punto A
                if (n % 2 == 0)
                {
                    if (n > mayorPares)
                    {
                        mayorPares = n;
                    }
                }else //Punto B
                {
                    conImpares++;
                }
                //Punto C
                if (primo(n))
                {
                    if (n < menorPrimo)
                    {
                        menorPrimo = n;
                    }
                }

                Console.WriteLine("Ingrese otro número o 0 para cortar: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor de los números pares es: " + mayorPares);
            Console.WriteLine("La cantidad de números impares son: " + conImpares);
            Console.WriteLine("El menor de los números primos es: " + menorPrimo);
        }

        static bool primo(int a)
        {
            int con = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    con++;
                }
            }
            if (con == 2)
            {
                return true;
            }else
            {
                return false;
            }
        }//Muchas gracias por el tiempo Maxi
    }
}
