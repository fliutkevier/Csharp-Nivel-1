using System;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BLOQUE IF: Condicionales.
            OPERADORES RELACIONALES
            > < >= <= == !=
            valor OP valor
            n1 > 10
            */
            
            /*
            int edad = 20;

            if(edad > 21){
                Console.WriteLine("Entra al IF");
            }

            Console.WriteLine("Fin del programa");
            */

            int edad = 35;
            /*
            //IF ANIDADO
            if(edad > 20){
                if(edad > 30){
                    Console.WriteLine("30 OFF");
                }else{
                    Console.WriteLine("21 OFF");
                }
            }else{
                Console.WriteLine("10 OFF");
            }
            */

            if(edad > 30)
                Console.WriteLine("30 OFF");
            else if(edad > 20)
                Console.WriteLine("21 OFF");
            else if(edad == 18)
                Console.WriteLine("10 OFF");
            else
                Console.WriteLine("5 OFF");
            

            Console.WriteLine("Fin del programa");
        }
    }
}
