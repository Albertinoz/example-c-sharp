using System;

namespace Delegado
{
    //Declaración de un delegate
    public delegate void MiDelegate(string mensaje);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia del delegate
            MiDelegate delegado = new MiDelegate(MiMetodo);

            //Invocación del delegate
            delegado("Hola desde el delegate");

            //Invocación del delegate por inferencia de tipos
            MiDelegate otroDelegado = MiMetodo;
            otroDelegado("Saludos desde otro Delegate");
        }

        //Método que coincide con la firma del Delegate
        static void MiMetodo(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
