using System;
using System.Reflection;

namespace Reflexion
{
    internal class Program
    {
        public int Propiedad1 { get; set; }
        public string Metodo1() => "Hola desde método 1";

        static void Main(string[] args)
        {
            //Obtiene información sobre el tipo Ejemplo
            Type tipo = typeof(Program);

            //Se obtiene la información sobre las propiedades del tipo
            PropertyInfo[] propiedades = tipo.GetProperties();
            foreach (PropertyInfo propiedad in propiedades) 
            {
                Console.WriteLine($"Propiedad: {propiedad.Name}, Tipo: {propiedad.PropertyType}");
            }

            //Se obtiene la información sobre los métodos del tipo
            MethodInfo[] metodos = tipo.GetMethods();
            foreach (MethodInfo metodo in metodos)
            {
                Console.WriteLine($"Método: {metodo.Name}, Retorno: {metodo.ReturnType}");
            }
        }
    }
}
