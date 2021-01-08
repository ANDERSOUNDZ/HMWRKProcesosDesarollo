using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDFIRSTtest
{
    [TestClass]
    public class CuandoVoyAComprarUnProducto
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

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
        public void CuantoEsValorTotalDelProductoConDescuentoUsandoRound()
        {
            var valorDelProducto = 500;
            var descuento = 15;
            var precioFinal = 425;

            var calculadora = new Calculadora();
            var precioTotal = calculadora.ObtenerValorTotalConDescuentoRound(valorDelProducto,descuento);

            Assert.AreEqual(precioFinal,precioTotal);
        }

        [TestMethod]
        public void CuantoEsValorTotalDelProductoConDescuentoConAbs()
        {
            var valorDelProducto = 500;
            var descuento = 15;
            var precioFinal = 425;

            var calculadora = new Calculadora();
            var precioTotal = calculadora.ObtenerValorTotalConDescuentoAbs(valorDelProducto, descuento);

            Assert.AreEqual(precioFinal, precioTotal);
        }

        //RESULTADOS AUN NO CONCLUYENTES , AQUI NO USO FRAMEWORK POR TENER OSX
        [TestMethod]
        [DataRow(8, 9, 17)]
        [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=C:\Data\MathsData.sdf;", "Numbers")]
        public void AumentarEnterosConCSVSinFramework()
        {
            var numero1 = 8;
            var numero2 = 9;
            var esperado = 17;

            var calculadora = new Calculadora();
            //int resultado = calculadora.AumentarEntero(numero1,numero2);
            //Assert.AreEqual(resultado, esperado);
        }

        //RESULTADOS AUN NO CONCLUYENTES , AQUI NO USO FRAMEWORK POR TENER OSX
        [TestMethod()]
        [DataSource(@"Provider=Microsoft.SqlServerCe.Client.4.0; Data Source=\Users\andersonchanchay\Documents\Desarrollo\SolucionesC#\TDDFIRSTtest\TDDFIRSTtest\Data;", "Data")]
        public void ProbandoSinFramework()
        {
            /*
             * ----
            */
        }

    }
}
