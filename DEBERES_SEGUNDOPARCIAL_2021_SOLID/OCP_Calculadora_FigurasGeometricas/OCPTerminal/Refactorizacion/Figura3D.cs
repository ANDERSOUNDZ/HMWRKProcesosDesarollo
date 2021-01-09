using System;
using System.Collections.Generic;
using System.Text;

namespace OCPTerminal.Refactorizacion
{
    abstract class Figura3D
    {
        public abstract double Volumen();
        public Color ColorSuperficie { get; set; }
    }
}