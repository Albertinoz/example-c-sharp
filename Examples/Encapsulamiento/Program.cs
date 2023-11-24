using System;

namespace Encapsulamiento
{
    public class Persona
    {
        //Atributos privados
        private string nombre;
        private int edad;

        //Propiedades públicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0)
                    edad = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.Nombre = "José";
            persona.Edad = 33;

            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }
    }
}
