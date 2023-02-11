using System;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int edad, con = 0, total = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese una edad:");
                edad = int.Parse(Console.ReadLine());
                
                if (edad > 18)
                {
                    total += edad;
                    con++;
                }
            }
            total /= con;
            Console.WriteLine("El promedio de las edades: " + total);
        }
    }
}
