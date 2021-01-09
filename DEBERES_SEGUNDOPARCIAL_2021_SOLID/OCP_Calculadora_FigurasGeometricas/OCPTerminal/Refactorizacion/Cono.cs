using System;

namespace OCPTerminal.Refactorizacion
{
    internal class Cono : Figura3D, IArea
    {
        public double Base { get; internal set; }
        public double Altura { get; internal set; }
        public double Radio { get; internal set; }
        public double Area()
        {
            return Math.PI * this.Radio * this.Radio + this.Altura;

        }

        public override double Volumen()
        {
            throw new NotImplementedException();
        }
    }
}