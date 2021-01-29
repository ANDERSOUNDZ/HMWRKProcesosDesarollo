using NUnit.Framework;

namespace NSubtitute
{
    public class OrderStateTest
    {
        public IPedido Pedido;
        public IBodega Bodega;

        const string JugoMora = "Jugo de Mora.";
        Bodega bodega = new Bodega();

        [SetUp]
        public void Setup()
        {
            Pedido = NSubstitute.Substitute.For<IPedido>();
            Bodega = NSubstitute.Substitute.For<IBodega>();
        }

        [Test]
        public void LaOrdenSeLlenaSiHaySuficienteEnLaBodega()
        {
            int existenciaJugoMora = 0;
            bodega.Add(JugoMora, 50);

            Pedido pedido = new Pedido(JugoMora, 50);
            pedido.Llenar(bodega);

            Assert.IsTrue(pedido.SeLleno);
            Assert.AreEqual(existenciaJugoMora, bodega.Existencia(JugoMora));
        }
    }
}