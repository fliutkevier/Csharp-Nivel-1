using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            CADENA FUENTE: “La mar estaba serena"
            CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            CADENA RESULTADO: “Li mir estibi sereni"
            */

            char[] cadena = new char[15];
            char[] c1 = new char[1];
            char[] c2 = new char[1];
            char letra;
            int con = 0;

            Console.WriteLine("Ingrese una cadena de caracteres: ");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && con < 15)
            {
                cadena[con] = letra;
                letra = char.Parse(Console.ReadLine());
                con++;
            }
            cadena[con] = '\0';

            Console.WriteLine("Ingrese un caracter: ");
            c1[0] = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro caracter: ");
            c2[0] = char.Parse(Console.ReadLine());

            for (int i = 0; i < con; i++)
            {
                if (cadena[i] == c1[0])
                {
                    cadena[i] = c2[0];
                }
                
            }
            for (int x = 0; x < 15; x++)
            {
                Console.Write(cadena[x]);
            }


            //COMO VA A SER EN EL FUTUROOOO:
            //comentar si se quiere procesar lo anterior.
            string frase;
            char letraActual;
            char letraNueva;

            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva: ");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("La cadena nueva es: ");
            Console.WriteLine(frase);


        }
    }
}
