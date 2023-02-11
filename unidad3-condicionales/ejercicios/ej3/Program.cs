using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // MI EJERCICIO
            float n1, descuento;
            Console.WriteLine("Ingrese el importe: ");
            n1 = float.Parse(Console.ReadLine());

            if(n1 >= 5000){
                descuento = n1 * 0.82f;
                Console.WriteLine("El importe final con descuento es: " + descuento);
            }else if(n1 >= 1000){
                descuento = n1 * 0.90f;
                Console.WriteLine("El importe final con descuento es: " + descuento);
            }else{
                Console.WriteLine("No hay descuento");
            }
            
            //CORRECIÓN
            // float importe;

            // Console.WriteLine("Ingrese el importe:");
            // importe = float.Parse(Console.ReadLine());

            // if(importe >= 1000){
                 //tengo que calcular algo...
            //     if(importe >= 5000)
            //         importe = importe * 0.82f;
            //     else
            //         importe = importe * 0.90f;
            // }
            // Console.WriteLine("El importe a cobrar es: " + importe);
        }
    }
}
