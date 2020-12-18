using System;

namespace MatematicaOSX
{
    internal class Calculadora
    {

        internal int AumentarEntero(int numeroEntero1, int numeroEntero2)
        {
            int sum = numeroEntero1;
            for (int i = 0; i < numeroEntero2; i++)
            {
                sum += 1;
            }
            return sum;
        }

        public int AumentarEnteroNegativo(int numeroEntero1, int numeroEntero2)
        {
            return numeroEntero1 + (numeroEntero2);
        }

        internal static double RaizCuadrada(double numero1)
        {
            if (numero1 < 0)
                throw new ArgumentException("No me enviesvalores negativos");
            return Math.Sqrt(numero1);
        }
    }
}   