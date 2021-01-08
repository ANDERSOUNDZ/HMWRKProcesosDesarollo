using System;

namespace EjemploNicolasSuares
{
    class FacturaFactorizada
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }

        // Método que calcula el total de la factura
        public void CalcularTotal()
        {
            // Calculamos la deducción
            Deduccion deduccion = new Deduccion(PorcentajeDeduccion);
            ImporteDeduccion = deduccion.CalcularDeduccion(ImporteFactura);
            // Calculamos el IVA
            Iva iva = new Iva();
            ImporteIVA = iva.CalcularIVA(ImporteFactura);
            // Calculamos el total
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}
