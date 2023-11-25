using System;
using System.Diagnostics;

namespace AssertEjem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sumar(7, 3);

            //Verifica que el resultado sea igual a 5
            Debug.Assert(resultado == 5, "La suma no es igual a 5");

            Console.WriteLine("Continúa...");
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
