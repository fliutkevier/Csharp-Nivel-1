using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int n, con, con1 = 0;
            Console.WriteLine("Ingrese un número para entrar a una lista: ");
            n = int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                con = 0;
                while (n > 0)
                {
                    con++;
                    Console.WriteLine("Ingrese un número o 0 para cortar: ");
                    n = int.Parse(Console.ReadLine());
                }
                con1++;
                Console.WriteLine("La lista " + con1 + " tiene " + con + " números.");
                Console.WriteLine("Ingrese un número para entrar a una lista o NEGATIVO para cortar: ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
