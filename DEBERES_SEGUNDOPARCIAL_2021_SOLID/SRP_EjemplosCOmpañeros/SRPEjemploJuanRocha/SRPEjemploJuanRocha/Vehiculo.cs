using System;

namespace SRPEjemploJuanRocha
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindraje { get; set; }
        public string Color { get; set; }
        public int Año { get; set; }
        public double Precio { get; set; }

        public double ImpuestoCarro(double precio)
        {
            return precio * 0.12;
        }
    }
}
