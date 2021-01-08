using System;

namespace SRPEjemploDavid
{
    class Iva
    {
        private const decimal IvaNormal = 0.12m;
        public decimal PorcentajeIva
        {
            get
            {
                return IvaNormal;
            }
        }

        public decimal CalcularIVA(decimal importe)
        {
            return importe * IvaNormal;
        }
    }
}
}
