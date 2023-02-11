using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL + F2 para cambiar el nombre de las variables o lo que sea en donde
            //sea que esté eso escrito.
            //int n1, n2, n3, promedio;
            float n1, n2, n3, promedio;


            Console.WriteLine("Ingrese la primer nota para realizar el promedio: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota para realizar el promedio: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercer nota para realizar el promedio: ");
            n3 = float.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio es: " + promedio); 

        }
    }
}
