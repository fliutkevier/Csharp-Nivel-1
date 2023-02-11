using System;

namespace ejemplo_double
{
    class Program
    {
        static void Main(string[] args)
        {
            //float - double - decimal
            
            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            //registro matutino
            int dia;
            double temperatura;
            Console.WriteLine("Cargue el registro matutino: ");

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("Ingrese el día: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese temperatura registrada: ");
                temperatura = double.Parse(Console.ReadLine());

                //el día que carga la persona va a ser el lugar del vector, para ingresar la temperatura:
                muestraMatutina[dia - 1] = temperatura;
                //y se va ordenando, sin importar el orden de los días que ponga el usuario.
            }
            for (int i = 0; i < 31; i++)
            {
                
            }
            for (int i = 0; i < 31; i++)
            {
                
            }

            //legajos y sueldo
            double[] sueldos = new double[50];
            int[] legajos = new int[50];
            
            for (int x = 0; x < 50; x++)
            {
                sueldos[x] = double.Parse(Console.ReadLine());
                //legajos[x] = double.Parse(Console.ReadLine()); (comentado porque da error rompe huevos)
            }
        }
    }
}
