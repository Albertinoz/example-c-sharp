using System;

namespace Arreglos
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
                default: Console.WriteLine("Ninguna opción elegida");
                    break;
            }
        }
    }
}
