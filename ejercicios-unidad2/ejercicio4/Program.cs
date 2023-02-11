using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //si yo quisiera que los datos que ingreso son constantes y para no estar cambiando
            //uno por uno, puedo asignarlo directamente a una variable, por ejemplo:
            // float comision = 0.05f
            // entonces cuando me piden que aumente o disminuya el porcentaje de la comisión
            // solamente cambio el valor y ya está

            float totalFacturado, comision, sueldoFinal;

            Console.WriteLine("¿Cuál es su sueldo total?");
            totalFacturado = float.Parse(Console.ReadLine());

            //100% >> totalFacturado ARS
            //5% >> ???
            // comision = 5 * totalFacturado / 100    REGLA DE 3 SIMPLE

            Console.WriteLine("El sueldo sin comisión es: " + totalFacturado);
            comision = totalFacturado * 0.05f;

            //Para incrementar porcentajes como sumarle el 10% a un total.
            //100 * 1 = 100
            //100 * 1.32 = 132
            //100 * 1.5 = 150
            //Para ver directamente el porcentaje del total (como yo lo hice)
            //100 * 0.90 = el 90% de 100
            //100 * 0.10 = el 10% de 100

            Console.WriteLine("Su comisión es de: " + comision);

            sueldoFinal = comision + totalFacturado;
            Console.WriteLine("Su sueldo total es: " + sueldoFinal);

        }
    }
}
