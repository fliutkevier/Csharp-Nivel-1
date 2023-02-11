using System;

namespace cicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLO INEXACTO
            int n, con = 0;
            Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                con++;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingresaste: " + con + " numeros.");
        }
    }
}
