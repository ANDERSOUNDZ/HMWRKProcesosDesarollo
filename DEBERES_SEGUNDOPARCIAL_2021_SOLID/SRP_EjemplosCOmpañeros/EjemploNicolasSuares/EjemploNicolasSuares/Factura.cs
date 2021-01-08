using System;

namespace EjemploNicolasSuares
{
    class Factura
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }
   
        public void CalcularTotal()
        {
            ImporteDeduccion = (ImporteFactura * PorcentajeDeduccion) / 100;
            ImporteIVA = ImporteFactura * 0.16m;
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}
