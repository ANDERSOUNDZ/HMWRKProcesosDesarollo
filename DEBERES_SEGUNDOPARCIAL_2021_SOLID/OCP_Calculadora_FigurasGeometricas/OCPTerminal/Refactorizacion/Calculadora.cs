﻿using System;

namespace OCPTerminal.Refactorizacion
{
    class Calculadora
    {
        public double CalcularArea(IArea figura)
        {
            return figura.Area();
        }

        abstract class Figura
        {
            public abstract double Area();
        }

    }
}