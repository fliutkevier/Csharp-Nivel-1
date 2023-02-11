using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float dist, vel, time;

            Console.WriteLine("Introduzca los kilometros existentes entre las ciudades: ");
            dist = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la velocidad del coche:");
            vel = float.Parse(Console.ReadLine());

            time = dist/vel;
            Console.WriteLine("Tiempo estimado en llegar: " + time.ToString("0.00"));
        }
    }
}
