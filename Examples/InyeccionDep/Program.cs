using System;

namespace InyeccionDep
{
    //Interfaz del servicio
    public interface IServicio
    {
        void RealizarTrabajo();
    }

    //Implementación del servicio
    public class Servicio : IServicio
    {
        public void RealizarTrabajo() 
        {
            Console.WriteLine("Trabajo realizado por el servicio");
        }
    }

    //Cliente que depende del servicio
    public class Cliente
    {
        private readonly IServicio servicio;

        //Constructor que acepta la dependencia
        public Cliente(IServicio _servicio) 
        {
            this.servicio = _servicio;
        }

        public void HacerAlgo()
        {
            //Utiliza el servicio
            servicio.RealizarTrabajo();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea una instancia del servicio
            IServicio servicio = new Servicio();

            //Crea instancia del cliente y pasa la dependencia
            Cliente cliente = new Cliente(servicio);

            //Utiliza el cliente
            cliente.HacerAlgo();
        }
    }
}
