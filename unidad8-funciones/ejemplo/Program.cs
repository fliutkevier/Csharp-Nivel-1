using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);
            //logica
            //resultado = n1 + n2;
            //llamado
            //                los valores que se envian a la funcion son "argumentos", lo que se recibe son parametros
            resultado = sumar(n1, n2);
            //               esto se está pasando por valor
            //PARA ENVIARLO COMO REFERENCIA, QUE LA VARIABLE SEA MODIFICABLE POR LA FUNCION, SE TIENE QUE PONER ref, tanto en el llamado como en la función.
            //resultado = sumar(ref n1, n2);
            //fin de la logica

            Console.WriteLine("El resultado es: " + resultado);
            //SCOPE = TODO LO QUE PASA ACA DENTRO
        }

                    //   parametros los que recibe
        static int sumar(int a, int b)
        //static int sumar(ref int a, int b)  (por referencia)
        {
            int r;
            r = a + b + 2;
            return r;
        }

        //void no devuelve nada
        //sirve para crear tipo de funciones
        static void pedirDatos(ref int j, ref int h)
        {
            Console.WriteLine("Ingrese un nro: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un nro: ");
            h = int.Parse(Console.ReadLine());
        }
    }
}
