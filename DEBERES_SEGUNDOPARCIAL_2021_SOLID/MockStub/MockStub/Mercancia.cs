namespace MockStub
{
    public class Mercancia
    {
        public int Peso { get; set; }
        public bool SeEnvio { get; set; }

        public void Enviar(ITransporte transporte)
        {
            if (transporte.PorcentajeCarga() >= 0.5)
            {
                transporte.Cargar(this.Peso);
                this.SeEnvio = true;
            }
            else
            {
                this.SeEnvio = false;
            }

        }
    }
}