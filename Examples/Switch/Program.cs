using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste la opción uno");
                    break;

                case 2:
                    Console.WriteLine("Seleccionaste la opción uno");
                    break;
                //case < 0:
                //    Console.WriteLine("Valor fuera de rango");
                //    break;
                default:
                    Console.WriteLine("Ninguna opción elegida");
                    break;
            }
        }
    }
}
