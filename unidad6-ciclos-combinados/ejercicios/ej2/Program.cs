using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide deterMaxar e informar:
            //- El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //- Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n, con, maxImpar = 0, grupoImpar = 0, acu, porcentajeMI = 0, Max, conOdernado = 0;
            bool bandera;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número entero: ");
                n = int.Parse(Console.ReadLine());
                con = 0;
                acu = 0;
                Max = n;
                bandera = true;
                while (n != 0)
                {
                    acu++;
                    if (n % 2 != 0)
                    {
                        con++;
                    }
                    if (n < Max)
                    {
                        Max = n;
                    }
                    else
                    {
                        bandera = false;
                    }
                    Console.WriteLine("Ingrese otro número entero o 0 para cortar: ");
                    n = int.Parse(Console.ReadLine());
                }
                if (con > maxImpar)
                {
                    maxImpar = con;
                    porcentajeMI = maxImpar * 100 / acu;
                    grupoImpar = i + 1;
                }
                if (bandera)
                {
                    conOdernado++;
                }

            }
            Console.WriteLine("El grupo " + grupoImpar + " tiene " + porcentajeMI + "% de impares y es el mayor.");
            Console.WriteLine("La cantidad de grupos ordenados son " + conOdernado);
        }
    }
}
