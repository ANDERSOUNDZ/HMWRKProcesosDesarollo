using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace RhinoMock
{
    [TestClass]
    public class MockTest
    {
        const string JugoMora = "Jugo de Mora.";
        const string JugoGuanabana = "Jugo de Guanabana.";

        //[TestMethod]
        //PRUEBA DESARROLLADA EN RHINOMOCK - NO FUNCIONA PUES ESTA DESARROLLADA EN .NET FRAMEWORK
        // PARA SISTEMA OPERATIVO MICROSOFT WINDOWS Y MI SISTEMA OPEATIVO ES MAC OSX
        /*
        public void LaOrdenSeLlenaSiHaySuficienteEnLaBodega()
        {
            var bodega = MockRepository.GenerateStub<IBodega>();
            int cantidadInicial = 50;
            bodega.Stub(p => p.Existencia(JugoMora)).Return(cantidadInicial);

            int cantidadPedida = 50;
            Pedido pedido = new Pedido(JugoMora, cantidadPedida);
            pedido.Llenar(bodega);

            Assert.IsTrue(pedido.SeLleno);
            //bodega.AssertWasCalled(e => e.ActualizarExistencia(JugoMora, cantidadInicial - cantidadPedida));
        }*/

        [TestMethod]
        //Refactorizacion de prueba en JustMock para .Net Core Mac OSX
        public void LaOrdenSeLlenaSiHaySuficienteEnLaBodegaMACOSX( )
        {
            int cantidadInicial = 50;
            var bodega = Mock.Create<IBodega>();
            bodega.Arrange(bodega => bodega.Existencia(JugoMora)).Returns(cantidadInicial);

            int cantidadPedida = 50;
            Pedido pedido = new Pedido(JugoMora, cantidadPedida);
            pedido.Llenar(bodega);
            Assert.IsTrue(pedido.SeLleno);
            bodega.Assert(bodega => bodega.Existencia(JugoMora));
        }
    }
}