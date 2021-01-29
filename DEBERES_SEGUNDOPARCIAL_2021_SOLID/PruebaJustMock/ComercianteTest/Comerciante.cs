using System;
using System.Collections.Generic;

namespace ComercianteTest
{
    internal class Comerciante
    {
        List<string> producto = new List<string>();
        public bool RecibeLaptops { get; internal set; }
        public bool ReservaLaptos { get; internal set; }
        public bool NoCompraLaptop { get; internal set; }

        internal void ComprarLaptops(Almacen almacen, int numeroLaptopsAComprar, string modeloLaptop)
        {
            if (almacen.LaptopsDisponibles(modeloLaptop) >= numeroLaptopsAComprar)
            {
                producto = almacen.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar);
                RecibeLaptops = true;
            }
            else if (almacen.LaptopsDisponibles(modeloLaptop) != numeroLaptopsAComprar)
            {
                producto = almacen.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar);
                ReservaLaptos = true;
            }
        }

        internal void RealizaCompra(Almacen almacen, int numeroLaptopsAComprar)
        {
            if (numeroLaptopsAComprar<almacen.LimiteDeCompra)
            {
                NoCompraLaptop = false;
            }
        }
    }
}