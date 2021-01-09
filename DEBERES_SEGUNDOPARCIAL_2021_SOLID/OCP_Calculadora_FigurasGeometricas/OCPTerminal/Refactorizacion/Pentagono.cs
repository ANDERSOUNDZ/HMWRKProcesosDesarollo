using System;
using System.Collections.Generic;
using System.Text;

namespace OCPTerminal.Refactorizacion
{
    internal class Pentagono : IArea
    {
        public static double NumeroDeLados { get { return 5; } }
        public double LongitudLados { get; internal set; }
        public double Apotema { get; internal set; }
        public double Area()
        {
            return Pentagono.NumeroDeLados * this.LongitudLados * Apotema / 2;
        }
    }
}