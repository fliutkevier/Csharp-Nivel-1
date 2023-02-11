using System;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
            int n, maxp = 0, meni = 0;
            int conPar = 0, conImpar = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0)
                {
                    conPar++;
                    if (conPar == 1)
                    {
                        maxp = n;
                    }else if (n > maxp)
                    {
                        maxp = n;
                    }

                }else if (n % 2 > 0)
                {
                    conImpar++;
                    if (conImpar == 1)
                    {
                        meni = n;
                    }else if (n < meni)
                    {
                        meni = n;
                    }
                }
            }
            Console.WriteLine("El máximo de los números pares: " + maxp);
            Console.WriteLine("El mínimo de los números impares: " + meni);
        }
    }
}
