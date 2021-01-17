using System;

namespace LiskovEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProyectoLiskov");

            
            Electrodomestico congelador = new Electrodomestico();

            CongeLador congelador1 = new CongeLador
            {
                tipo = "Electrodomestico",
                marca = "Bosh"
            };
            congelador1.Congelar();

        }
    }
}
