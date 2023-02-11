using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clicos Combinados:
            
            //For con For
            //en el caso de que quiera hacer esto 100 veces, ¿Voy a copiar el ciclo for 100 veces?
            /*int prom, acu = 0, n;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu += n;
            }
            prom = acu / 20;
            Console.WriteLine("El promedio es: " + prom);*/

            //PROMEDIO DE EDAD DE 20 PERSONAS DE 10 GRUPOS.
            /*int prom, acu, n;
            for (int i = 0; i < 10; i++)
            {
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es: " + prom);
            }*/

            //FOR CON WHILE
            /*int n;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                int acu = 0, con = 0, prom;
                while (n != 0)
                {
                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / con;
                Console.WriteLine("El promedio de edad es: " + prom);
            }*/
            
            //WHILE CON FOR
            /*
            int prom, acu, n;
            Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar:");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                acu = 0;
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar:");
                n = int.Parse(Console.ReadLine());
            }
            */

            //WHILE CON WHILE

            int n;
            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
            
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                int acu = 0, con = 0, prom;
                while (n != 0)
                {
                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / con;
                Console.WriteLine("El promedio de edad es: " + prom);

                Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar: ");
                n = int.Parse(Console.ReadLine());
            }


        }
    }
}