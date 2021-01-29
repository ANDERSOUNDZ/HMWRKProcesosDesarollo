namespace NSubtitute
{
    internal class Pedido : IPedido
    {
        private string Producto;
        private int Cantidad;

        public Pedido(string producto, int cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
        }

        public bool SeLleno { get; internal set; }

        public void Llenar(Bodega bodega)
        {
            if (bodega.Existencia(Producto) >= Cantidad)
            {
                SeLleno = true;
                int existenciaTotal = bodega.Existencia(Producto) - Cantidad;
                bodega.ActualizarExistencia(Producto, existenciaTotal);
            }
        }
    }
}