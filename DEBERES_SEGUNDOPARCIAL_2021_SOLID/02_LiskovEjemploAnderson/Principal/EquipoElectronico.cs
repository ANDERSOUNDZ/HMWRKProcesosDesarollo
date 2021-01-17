using System;
namespace Principal
{
    abstract class EquipoElectronico
    {
        protected string marca; 
        public EquipoElectronico( string marcaElectrodomestico)
        {
            marca = marcaElectrodomestico;
        }

        public abstract void Electrodomestico();
    }
}
