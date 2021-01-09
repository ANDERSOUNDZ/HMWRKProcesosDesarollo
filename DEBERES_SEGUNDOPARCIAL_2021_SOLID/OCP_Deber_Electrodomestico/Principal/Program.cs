using System;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Electrodomestico");

            EquipoElectronico miElectrodomestico1 = new Lavadora("Bosh");
            miElectrodomestico1.Electrodomestico();

            EquipoElectronico miElectrodomestico2 = new Refrigerador("Mave");
            miElectrodomestico2.Electrodomestico();
        }
    }
}
