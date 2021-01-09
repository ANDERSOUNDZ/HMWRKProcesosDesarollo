using System;

namespace OCPTerminal.Refactorizacion
{
    internal class Trapecio : IArea
    {
        public double Base1 { get; internal set; }
        public double Base2 { get; internal set; }
        public double Altura { get; internal set; }

        public double Area()
        {
            return this.Altura*(Base1*Base2/2);
        }
    }
}