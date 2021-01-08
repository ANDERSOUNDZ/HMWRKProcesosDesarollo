using System;

namespace EjemploNicolasSuares
{
    class Iva
    {
        private const decimal IvaNormal = 0.16m;
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