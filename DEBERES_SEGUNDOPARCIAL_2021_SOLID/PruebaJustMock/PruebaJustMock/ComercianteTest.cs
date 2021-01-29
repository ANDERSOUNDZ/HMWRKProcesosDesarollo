using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace PruebaJustMock
{
    [TestClass]
    public class ComercianteTest
    {
        [TestMethod]
        public void DadoQueExisteLaptopsDisponiblesCuandoComproLaptopsEntoncesReciboLaptops()
        {
            //Arrange = Precondiciones - Configuracion inicial- DADO
            string modeloLaptop = "Dell";
            int numeroLaptopsAComprar = 5;
            var bodega = Mock.Create<Bodega>();
            bodega.Arrange(x => x.LaptopsDisponibles(modeloLaptop)).Returns(20);
            bodega.Arrange(x => x.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar))
                .Returns(new List<string> { "DellGM2020","DellGM2018", "DellGM2019", "DellGM2017", "DellGM2019" });
            //Act - Ejecutar lo que se va probar - metodo a probar - SUT - Cuando
            Comerciante comerciante = new Comerciante();
            comerciante.ComprarLaptops(bodega, numeroLaptopsAComprar, modeloLaptop);
            //Assert -Verificacion- Afirmar que es verdad- Que paso luego - Entonces
            Assert.IsTrue(comerciante.RecibirLaptops);
            bodega.Assert(x => x.LaptopsDisponibles(modeloLaptop));
            bodega.Assert(x => x.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar));
        }

        [TestMethod]
        public void DadoQueNoExisteLaptopsGamingDisponiblesCuandoComproLaptopsEnLineaReservoLaptops()
        {
            string modeloLaptop = "Dell";
            int numeroLaptopsAComprar = 2;

            var bodega = Mock.Create<Bodega>();
            bodega.Arrange(laptop => laptop.LaptopsDisponibles(modeloLaptop)).Returns(0);
            bodega.Arrange(laptop => laptop.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar)).Returns(new List<string> { "DellGM2020", "DellGM2018" });

            Comerciante comerciante = new Comerciante();
            comerciante.ComprarLaptops(bodega, numeroLaptopsAComprar, modeloLaptop);

            Assert.IsTrue(comerciante.ReservoLaptops);
            bodega.Assert(laptop => laptop.LaptopsDisponibles(modeloLaptop));
            bodega.Assert(laptop => laptop.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar));
        }

        [TestMethod]
        public void DadoQueNoHayLaptopsDisponiblesCuandoQuieroComprarLaptopsNoseCompraNinguna()
        {
            string modeloLaptop = "Dell";
            int numeroLaptopsAComprar = 8;

            var bodega = Mock.Create<Bodega>();
            bodega.Arrange(laptop => laptop.LaptopsDisponibles(modeloLaptop)).Returns(0);

            Comerciante comerciante = new Comerciante();
            comerciante.ComprarLaptops(bodega, numeroLaptopsAComprar, modeloLaptop);

            Assert.IsFalse(comerciante.RecibirLaptops);
            bodega.Assert(laptop => laptop.LaptopsDisponibles(modeloLaptop));
        }
    }
}