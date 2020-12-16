using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace MatematicaOSX
{

    [TestClass]
    public class CuandoUsoLaCalculadora
    {
        private TestContext testContextInstance;
        //public abstract System.Data.DataRow DataRow { get; }
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        /*
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
            DeploymentItem("data.csv")]
        public void AumentarEntero()
        {
            
            var numero1 = Int32.Parse(TestContext.DataRow["number1"].ToString());
            var numero2 = Int32.Parse(TestContext.DataRow["number2"].ToString());
            var esperado = Int32.Parse(TestContext.DataRow["sum"].ToString());

            var calc = new Calculadora();
            var resultado = calc.AumentarEntero(numero1, numero2);

            Assert.AreEqual(esperado, resultado);
        }
        */

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroPositivoObtengoPositivo()
        {
            var numero1 = 25;
            var esperado = 5;

            var calculadora = new Calculadora();
            var resultado = calculadora.RaizCuadrada(numero1);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroNegotivoDisparaArgumentException()
        {
            var numero1 = -5;

            var calculadora = new Calculadora();

            Assert.ThrowsException<ArgumentException>(()=>  calculadora.RaizCuadrada(numero1));
        }

    }
}
