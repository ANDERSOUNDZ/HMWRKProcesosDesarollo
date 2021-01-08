using System;
using System.Collections.Generic;

namespace SRPEjemploMarisol
{
    public class Fact
    {
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
    }
}
