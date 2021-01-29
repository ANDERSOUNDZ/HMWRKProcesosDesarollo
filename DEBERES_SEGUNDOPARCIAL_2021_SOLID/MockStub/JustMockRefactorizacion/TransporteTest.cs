using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using MockStub;
using Telerik.JustMock.Helpers;

namespace JustMockRefactorizacion
{
    [TestClass]
    public class TransporteTest
    {
        [TestMethod]
        public void SiElTransporteEstaLlenoLaMitadOMasPuedePartirMock()
        {
            var transporte = Mock.Create<ITransporte>();
            transporte.Arrange(t => t.PorcentajeCarga()).Returns(0.5);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.Assert(t => t.PorcentajeCarga());
            transporte.Assert(t => t.Cargar(mercancia.Peso));
        }

        [TestMethod]
        public void SiUnaCargaInicialMasElPesoNoEnviaMock()
        {
            var transporte = Mock.Create<ITransporte>();
            transporte.Arrange(t => t.PorcentajeCarga()).Returns(0.5);

            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.Assert(t => t.PorcentajeCarga());
            transporte.Assert(t => t.Cargar(mercancia.Peso));
        }

        [TestMethod]
        public void SiElPEsoDelEnvioMasLaCargaExcedeLaCapacidadNoEnviaMock()
        {
            var transporte = Mock.Create<ITransporte>();
            transporte.Arrange(t => t.PorcentajeCarga()).Returns(0.5);

            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.Assert(t => t.PorcentajeCarga());
            transporte.Assert(t => t.Cargar(mercancia.Peso));
        }

        [TestMethod]
        public void PruebaConUnaCargaInicialSeEnviaMock()
        {
            var transporte = Mock.Create<ITransporte>();
            transporte.Arrange(t => t.PorcentajeCarga()).Returns(0.5);
    
            transporte.Capacidad = 600;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.Assert(t => t.PorcentajeCarga());
            transporte.Assert(t => t.Cargar(mercancia.Peso));
        }
    }
}
