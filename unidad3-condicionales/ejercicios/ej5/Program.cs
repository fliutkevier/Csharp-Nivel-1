using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //MI EJERCICIO
            
            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese 4 números:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100){
                Console.WriteLine(n1 + " Es mayor a 100");
            }
            if(n2 > 100){
                Console.WriteLine(n2 +" Es mayor a 100");
            }
            if(n3 > 100){
                Console.WriteLine(n3 + " Es mayor a 100");
            }
            if(n4 > 100){
                Console.WriteLine(n4 + " Es mayor a 100");
            }
            
            //correcion
            /* POR ALGUNA RAZÓN, NO ME CUENTA LA VARIABLE CONTADOR
            int a, b, c, d;
            int contador;
            Console.WriteLine("Ingrese 4 números:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if(a > 100){
                Console.Write(a);
                contador++;
            }
            if(b > 100){
                Console.Write(b);
                contador++;
            }
            if(c > 100){
                Console.Write(c);
                contador++;
            }
            if(d > 100){
                Console.Write(d);
                contador++;
            }
            if(contador != 0){
                Console.Write("Son mayores a 100...");
            }
            Console.WriteLine("Fin del programa");
            */
        }
    }
}
