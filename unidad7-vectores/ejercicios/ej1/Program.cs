using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int[] vector = new int[10];
            int max = 0, pos = 0;
            Console.WriteLine("Ingrese 10 numeros enteros:");

            for (int i = 0; i < 10; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());    
            }
            for (int x = 0; x < 10; x++)
            {
                if(vector[x] > max)
                {
                    max = vector[x];
                    pos = x + 1;
                }
                if(x == 9)
                {
                    Console.WriteLine("El valor máximo es " + max + " en la posición " + pos + ".");
                }
            }
        }
    }
}
