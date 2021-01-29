using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace MockStub
{
    [TestClass]
    public class TransporteTest
    {
        [TestMethod]
        public void SiElTransporteEstaLlenoLaMitadOMasPuedePartirMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }

        [TestMethod]
        public void SiElTransporteEstaLlenoLaMitadOMasPuedePartir()
        {
            var transporte = new Transporte();
            transporte.Capacidad = 1000;
            transporte.Cargar(400);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsFalse(mercancia.SeEnvio);
        }

        [TestMethod]
        public void SiUnaCargaInicialMasElPesoNoEnviaMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }
        [TestMethod]
        public void SiElPEsoDelEnvioMasLaCargaExcedeLaCapacidadNoEnviaMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }

        [TestMethod]
        public void PruebaConUnaCargaInicialSeEnviaMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            transporte.Capacidad = 600;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }
    }
}
