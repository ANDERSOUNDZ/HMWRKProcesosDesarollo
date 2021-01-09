using System;
namespace Principal
{
    class Refrigerador : EquipoElectronico
    {
        public Refrigerador(string marcaElectrodomestico): base(marcaElectrodomestico)
        {
        }
        public override void Electrodomestico()
        {
            Console.WriteLine("Esta es la marca del El Electrodomestico: {0}", marca);
        }
    }
}
