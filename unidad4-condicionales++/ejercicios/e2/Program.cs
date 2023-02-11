using System;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            float it, l, resultado;
            Console.WriteLine("Ingrese el importe total a pagar:");
            it = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros:");
            l = float.Parse(Console.ReadLine());

            if (l > 500)
            {
                resultado = it * 0.75f;
                //it *= 0.75
                Console.WriteLine("Total con descuento: " + resultado);
            }else if (l >= 301 && l <= 500)
            {
                resultado = it * 0.85f;
                //it *= 0.85f;
                Console.WriteLine("Total con descuento: " + resultado);
            }else if (l >= 101 && l <= 300)
            {
                resultado = it * 0.90f;
                //it *= 0.90f;
                Console.WriteLine("Total con descuento: " + resultado);
            }else
            {
                Console.WriteLine(it);
            }

            //CORRECION
            //CORRECION
            //CORRECION
            /*float importeTotal, litros;
            Console.WriteLine("Ingrese el importe total a pagar:");
            importeTotal = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros:");
            litros = float.Parse(Console.ReadLine());

            if (litro > 500)
            {
                importeTotal *= 0.75f;
            }else if (litros > 300)
            {
                importeTotal *= 0.85f;
            }else if (litros > 100)
            {
                importeTotal *= 0.90f;
            }
            Console.WriteLine("El importe final a pagar es: " + importeTotal);
            */
        }
    }
}
