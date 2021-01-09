using System;

namespace OCPTerminal.Refactorizacion
{
    internal class Tetraedro : IArea
    {
        public int Lado { get; internal set; }

        public double Area()
        {
            return Math.Sqrt(3)*Lado*Lado;
        }
    }
}