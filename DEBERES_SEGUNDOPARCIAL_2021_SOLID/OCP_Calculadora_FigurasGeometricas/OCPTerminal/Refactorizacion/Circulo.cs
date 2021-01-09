using System;

namespace OCPTerminal.Refactorizacion

{
    internal class Circulo : IArea
    {
        public double Radio { get; internal set; }

        public double Area()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }
    }
    
}