﻿using System;

namespace acu_con
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ACUMULADORES Y CONTADORES
            int contador = 0, e1 = 20, e2 = 13, e3 = 30;
            int acumulador = 0;
            int promedio;
            //incremento ++
            //decremento --
            //ejemplo de CUANTOS SON MAYORES A 18
            if(e1 > 18){
                contador ++;
                acumulador += e1;
            }
            if(e2 > 18){
                contador ++;
                acumulador += e2;
            }
            if(e3 > 18){
                contador ++;
                acumulador += e3;
            }
            promedio = acumulador / contador;

            Console.WriteLine("El promedio es: " + promedio);

        }
    }
}
