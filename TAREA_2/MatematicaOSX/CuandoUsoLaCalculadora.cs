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
         * ESTE PROCESO SE DESARROLLA EN WINDOWS CON .NET FRAMEWORK,
         * MI SISTEMA OPERATIVO ES MAC, Y CAMBIAR CIERTOS ASPECTOS.
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
        [DataRow(1, 2, 3)]
        public void AumentarEntero(int numeroEntero1, int numeroEntero2, int esperado)
        {
            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2);

            Assert.AreEqual(esperado, resultado, "numeroEntero1:<{0}> numeroEntero2:<{1}>",
            new object[] { numeroEntero1, numeroEntero2 });
        }

        [TestMethod]
        [DataRow(2, -3, -1)]
        public void AumentarEnteroNegativo(int numeroEntero1, int numeroEntero2, int esperado)
        {
            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEnteroNegativo(numeroEntero1, numeroEntero2);

            Assert.AreEqual(esperado, resultado, "",
            new object[] { numeroEntero1, numeroEntero2 });
        }



        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroPositivoObtengoPositivo()
        {
            var numero1 = 25;
            var esperado = 5;

            var calculadora = new Calculadora();
            var resultado = Calculadora.RaizCuadrada(numero1);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroNegotivoDisparaArgumentException()
        {
            var numero1 = -5;

            var calculadora = new Calculadora();

            Assert.ThrowsException<ArgumentException>(()=> Calculadora.RaizCuadrada(numero1));
        }
    }
}
