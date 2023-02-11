using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            int promedio, acu = 0;
            int[] notas = new int[10];
            
            Console.WriteLine("Ingrese las 10 notas: ");
            for (int i = 0; i < 10; i++)
            {
                notas[i] = int.Parse(Console.ReadLine());
                acu += notas[i];
            }
            promedio = acu / 10;
            for (int x = 0; x < 10; x++)
            {
                if (notas[x] > promedio)
                {
                    Console.WriteLine("Mayor que el promedio: " + notas[x]);
                }
            }
        }
    }
}
