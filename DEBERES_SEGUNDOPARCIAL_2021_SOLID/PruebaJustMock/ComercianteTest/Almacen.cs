using System;
using System.Collections.Generic;
namespace ComercianteTest
{
    public abstract class Almacen
    {

        public abstract int LaptopsDisponibles(string modeloLaptop);
        public abstract List<string> GenerarRecibo(string modeloLaptop, int numeroLaptopsAComprar);
        public abstract int LimiteDeCompra { get; set;}
    }
}