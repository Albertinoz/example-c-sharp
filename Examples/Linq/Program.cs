using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de obejtos
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Jose", Edad = 33},
                new Persona { Nombre = "Fer", Edad = 21},
                new Persona { Nombre = "Jade", Edad = 2},
                new Persona { Nombre = "Santi", Edad = 15}
            };

            //Consulta con Linq
            var personasMayores = from persona in personas
                                  where persona.Edad > 18
                                  select persona;

            //Muestra resultado
            foreach (var persona in personasMayores)
            {
                Console.WriteLine($" {persona.Nombre} - {persona.Edad} años");
            }
        }
    }

    //Definición de la clase Persona
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
