using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vectores = Array = Arreglo
            //así se declara una variable normalmente:
            int n;
            //así se declara un vector, de 10:
            int[] numeros = new int[10];

            //asignar a un espacio especifico del vector un valor...
            numeros[6] = 1;

            /*
            como se van guardando los datos de los vectores...
             0 1 2 3 4 5 6 7 8 9
            |7| | | | | |1| | |32450 |
            */

            for (int x = 0; x < 10; x++)
            {
                 Console.WriteLine("Ingrese la nota: ");
                 n = int.Parse(Console.ReadLine());
                 numeros[x] = n;
            }
            //en el caso que quiero hacer un promedio con las notas.
            int acu = 0;
            int prom = 0;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
                Console.WriteLine("askjhdfkj" + numeros[x]);
            }

            //int prom = acu / 10; (comentado porque da error rompe huevos)
            Console.WriteLine(prom);
        }
    }
}
