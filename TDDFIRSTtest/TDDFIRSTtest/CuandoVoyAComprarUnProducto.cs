using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDFIRSTtest
{
    [TestClass]
    public class CuandoVoyAComprarUnProducto
    {
        [TestMethod]
        public void CuantoMeVoyAAhorrarEnDolares()
        {
            var costoDeProducto = 400;
            var descuento = 35;
            var ahorroDolaresEsperado = 140;

            var calculadora = new Calculadora();
            var ahorroEnDolares = calculadora.ObtenerAhorro(descuento, costoDeProducto);

            Assert.AreEqual(ahorroDolaresEsperado, ahorroEnDolares);
        }

        [TestMethod]
        public void CuantoEsValorTotalDelProductoConDescuento()
        {
            var valorDelProducto = 500;
            var descuento = 15;
            var precioFinal = 425;

            var calculadora = new Calculadora();
            var precioTotal = calculadora.ObtenerValorTotalConDescuento(valorDelProducto,descuento);

            Assert.AreEqual(precioFinal,precioTotal);
        }

    }
}
