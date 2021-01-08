using System;

namespace SRPEjemploMarisol
{
    public class CalculadoraFact
    {
        public double CalcularSubTotal(Fact factura)
        {
            double subtotal = 0;
            //for (int i = 0; i < factura.Detalles.Count; i++)
            // {
            //total += factura.Detalles[i].PrecioUnitario * factura.Detalles[i].Cantidad;
            //  }
            foreach (DetalleFactura actual in factura.Detalles)
            {
                subtotal += actual.PrecioUnitario * actual.Cantidad;
            }
            Console.WriteLine("el subtotal es{0}:", subtotal);

            return subtotal;
        }

        public void CalcularTotal(Fact factura)
        {
            double total = CalcularSubTotal(factura) + CalcularIva(factura);

            Console.WriteLine("el total es{0}:", total);
        }

        public double CalcularIva(Fact factura)
        {

            double precioIva = CalcularSubTotal(factura) * 0.12;

            Console.WriteLine("el precio del IVA es: " + precioIva);

            return precioIva;
        }

    }
}
