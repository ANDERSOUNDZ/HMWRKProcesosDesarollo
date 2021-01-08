using System;

namespace SRPEjemploMarisol
{
    public class DetalleFactura
    {
        public int IdDetalleFactura { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
    }
}
