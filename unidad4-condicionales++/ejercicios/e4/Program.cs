using System;

namespace e4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int a, b, c;
            int suma, producto;
            Console.WriteLine("Ingrese un número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            c = int.Parse(Console.ReadLine());
            suma = a + b;
            producto = b * c;
            if (suma > producto)
            {
                Console.WriteLine("la suma es mayor al producto entre el segundo y el tercero");
            }
        }
    }
}
