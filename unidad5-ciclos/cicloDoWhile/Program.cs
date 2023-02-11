using System;

namespace cicloDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                con++;
            } while (n != 0);
        }
    }
}
