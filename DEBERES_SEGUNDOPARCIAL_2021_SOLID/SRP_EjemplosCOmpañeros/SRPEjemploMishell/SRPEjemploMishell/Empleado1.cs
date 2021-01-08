using System;

namespace SRPEjemploMishell
{
    class Empleado1
    {

        public string Nombre { get; set; }
        public string Puesto { get => Puesto; set => Puesto = value; }
        public int Edad { get => Edad; set => Edad = value; }
        public double Sueldo { get => Sueldo; set => Sueldo = value; }

        public double CalcularImpuestoIess(double sueldo)
        {
            return sueldo * 9.45;
        }
    }
}
