using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES
            //es un bloque de codigo, un programa o mini programa...
            //ESTA ES LA FUNCION MAIN, LA PRINCIPAL.
            /*
            PARTES DE LA FUNCIÓN
            -CABECERA
             1. TIPO DE DATO
             2. NOMBRE
             3. Opcional: PARAMETROS
            -CUERPO
             Definición/Logica
             Opcional: Retorno de valor/resultado
            */
            //INVOCACION
            int n = devolverUno();
            Console.WriteLine("Fin del Programa: " + n);
            //otra posibilidad para mostrar
            Console.WriteLine("Fin del Programa: " + devolverUno());


        }

        //tipo de dato: int
        //nombre: devolverUno
        //sin parametros
        static int devolverUno()
        {
            //logica
            int nro = 15;
            return nro;
        }
    }
}
