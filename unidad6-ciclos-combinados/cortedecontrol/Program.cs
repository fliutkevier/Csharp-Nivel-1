using System;

namespace cortedecontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            //CORTE DE CONTROL
            //sirve para manejar los lotes de datos agrupados.
            
            //LEGAJO, EDAD, SUELDO, CODIGO DE EQUIPO(entre 1 y 50)
            int legajo, edad, codigoEquipo, equipoActual;
            float sueldo;

            Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {
                //esto hace la diferencia del corte de control...
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                    //acá va el proceso...


                    Console.WriteLine("Ingrese el legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLine());

                    //acá se pueden mostrar resultados
                }
            }
            //acá se pueden mostrar resultados
        }
    }
}
