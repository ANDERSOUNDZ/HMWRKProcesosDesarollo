using System;

namespace TDDFIRSTtest
{
    internal class Calculadora
    {
        internal int ObtenerAhorro(int descuento, int costoDeProducto)
        {
            var ahorroEnDolares = Mover2PosicionesAlAIzquierdaYMultiplicar(costoDeProducto, descuento);
            return ahorroEnDolares;
        }

        private int Mover2PosicionesAlAIzquierdaYMultiplicar(int costoDeProducto, int descuento)
        {
            return (costoDeProducto/100)* descuento;
        }

        internal double ObtenerValorTotalConDescuentoRound(double valorDelProducto, int descuento)
        {
            var ahorroDolar = Mover2PosicionesAlAIzquierdaYMultiplicarYRestarElAhorroEnDolaresRound(valorDelProducto, descuento);
            var valorTotal = valorDelProducto - ahorroDolar ;
            return valorTotal;
        }

        private double Mover2PosicionesAlAIzquierdaYMultiplicarYRestarElAhorroEnDolaresRound(double valorDelProducto, int descuento)
        {
            return Math.Round(valorDelProducto/ 100) * descuento;
        }

        internal double ObtenerValorTotalConDescuentoAbs(int valorDelProducto, int descuento)
        {
            var ahorroDolar = Mover2PosicionesAlAIzquierdaYMultiplicarYRestarElAhorroEnDolaresAbs(valorDelProducto, descuento);
            var valorTotal = valorDelProducto - ahorroDolar;
            return valorTotal;
        }

        private double Mover2PosicionesAlAIzquierdaYMultiplicarYRestarElAhorroEnDolaresAbs(int valorDelProducto, int descuento)
        {
            return Math.Abs(valorDelProducto / 100) * descuento;
        }
    }
}