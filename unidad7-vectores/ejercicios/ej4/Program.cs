using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10.
            */
            int[] totalCantidadVendida = new int[15];
            int nroArticulo, cantidad;
            int mayor = 0;

            for (int i = 0; i < 15; i++)
            {
                totalCantidadVendida[i] = 0;
            }

            Console.WriteLine("Ingrese un numero de articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {
                
                totalCantidadVendida[nroArticulo - 1] += cantidad;

                Console.WriteLine("Ingrese un numero de articulo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());

            }

            //punto A
            int pos = 0;
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    mayor = totalCantidadVendida[i];
                }
                else if (totalCantidadVendida[i] > mayor)
                {
                    mayor = totalCantidadVendida[i];
                    pos = i;
                }
            }
            Console.WriteLine("El articulo más vendido fue " + mayor + " en la posición " + pos);

            //punto B
            for (int i = 0; i < 15; i++)
            {
                if (totalCantidadVendida[i] == 0)
                {
                    Console.WriteLine("El articulo " + (i + 1) + " no tuvo ventas.");
                }
            }

            //punto C
            Console.WriteLine("El articulo numero 10 vendió " + totalCantidadVendida[9] + " unidades");
        }
    }
}
