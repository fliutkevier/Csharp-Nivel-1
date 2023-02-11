using System;

namespace CicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLO EXACTO
            //QUE SE REPITA HOLA MUNDO 5 VECES
            /*for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hola mundo " + (i + 1));
            }*/

            int n = 0, promedio, suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la nota:");
                n = int.Parse(Console.ReadLine());
                suma += n;

            }

            promedio = suma / 5;
            Console.WriteLine("El promedio de notas es: " + promedio);
        }
    }
}
