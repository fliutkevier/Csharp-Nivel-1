using System;

namespace e1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            //mi segunda forma de hacerlo
            int con = 0;
            for (int i = 0; i < 10; i++)
            {
                con++;
                Console.WriteLine(con);
            }
        }
    }
}
