using System;

namespace primerejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND &&, OR ||, NOT !
            //if(edad > 10 && edad < 30)
            //INCREMENTO ++ DECREMENTO --
            //ACUMULADORES <variable>+=10  (z+=20)
            //acumulador restando <variable>-=10   (h-=30)
            int edad = 20;
            char inicial = 'J';

            //  true     &&       true
            if (edad > 20 && inicial == 'H'){
                Console.WriteLine("21 OFF...");
            }
            //true && true == true
            //false && true == false
            //true && false == false
            //false && false == false

            //OR ||
            //  true     ||       true
            if (edad > 20 || inicial == 'H'){
                Console.WriteLine("21 OFF...");
            }
            //true || false == true
            //false || true == true
            //true || true == true
            //false || false == false

            //COMBINADOS && ||
            /*
            int edad = 20;
            char inicial = 'J';

            if ((inicial == 'H' || inicial == 'J') && edad > 20){
                Console.WriteLine("21 OFF...")
            }
            console.WriteLine("Fin Programa");

            //NOT operador !
            int edad = 20;
            if (!(inicial == 'H' || inicial == 'J') && edad > 20){
                Console.WriteLine("21 OFF...")
            }
            console.WriteLine("Fin Programa");
            */
        }
    }
}
