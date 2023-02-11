using System;

namespace ejemplo_char
{
    class Program
    {
        static void Main(string[] args)
        {
            //CADENA DE CARACTERES
            char[] asistencias = new char[10];
            asistencias[0] = 'P';
            asistencias[1] = 'P';
            asistencias[2] = 'A';
            //no es lo mismo char que string.
            //string de fondo usar char, pero de una forma diferente.
            
            //BARRA CERO
            //\0
            asistencias[5] = '\0';
            //se toma como UN caracter, aunque tenga dos porque es un caracter especial, este le da fin a una cadena de caracteres.

            //EJEMPLO INCOMPLETO
            //EJEMPLO INCOMPLETO
            //EJEMPLO INCOMPLETO
            //EJEMPLO INCOMPLETO

            char[] nombre = new char[10];

            char j, letra;
            int indice = 0;
            j = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su nombre letra por letra... y termina con punto");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            nombre[indice - 1] = '\0';

            //para mostrar
            Console.WriteLine("Hola ");
            indice = 0;
            while (nombre[indice] != '\0')
            {
                Console.WriteLine(nombre[indice]);
                indice++;
            }
        }
    }
}
