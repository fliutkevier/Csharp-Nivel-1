using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            int n, con1 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el " + (i + 1) + "° número.");
                n = int.Parse(Console.ReadLine());
                int con = 0;
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                    {
                        con++;
                    }
                }
                if (con == 2)
                {
                    con1++;
                }
            }
            Console.WriteLine(con1 + " son primos.");
        }
    }
}