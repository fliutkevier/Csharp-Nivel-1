using System;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, ram, disco;
            int procesadoryR = 0;
            Console.WriteLine("Ingrese la opción de procesador que desee:");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la opción de RAM que desee:");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea agrandar el disco? (ingresa 1 para extender y 0 para no extender): ");
            disco = int.Parse(Console.ReadLine());

            switch (procesador)
            {
                case 1:
                    switch (ram)
                    {
                        case 1:
                            procesadoryR = 800;
                            break;
                        case 2:
                            procesadoryR = 900;
                            break;
                        case 3:
                            procesadoryR = 1000;
                            break;
                    }
                    break;
                case 2:
                    switch (ram)
                    {
                        case 1:
                            procesadoryR = 900;
                            break;
                        case 2:
                            procesadoryR = 1000;
                            break;
                        case 3:
                            procesadoryR = 1400;
                            break;
                    }
                    break;
                case 3:
                    switch (ram)
                    {
                        case 1:
                            procesadoryR = 1200;
                            break;
                        case 2:
                            procesadoryR = 1400;
                            break;
                        case 3:
                            procesadoryR = 2000;
                            break;
                    }
                    break;
            
            }
            if (disco == 1)
            {
                procesadoryR += 300;
            }

            Console.WriteLine(procesadoryR);
            
            
            
        }
    }
}
