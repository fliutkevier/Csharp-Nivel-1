using System;

namespace ej4
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

            if(n1 < n2){
                Console.WriteLine(n1 + " es el menor");
            }else if(n2 < n3){
                Console.WriteLine(n2 + " es el menor");
            }else if(n3 < n4){
                Console.WriteLine(n3 + " es el menor");
            }else{
                Console.WriteLine(n4 + " es el menor");
            }

            //CORRECIÓN
            /*int a, b, c, d, menor;
            Console.WriteLine("Ingrese 4 números:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if(a < b){
                menor = a;
            }else{
                menor = b;
            }
            if(c < menor){
                menor = c;
            }
            if(d < menor){
                menor = d;
            }
            Console.WriteLine("El valor menor es: " + menor);
            */
        }
    }
}
