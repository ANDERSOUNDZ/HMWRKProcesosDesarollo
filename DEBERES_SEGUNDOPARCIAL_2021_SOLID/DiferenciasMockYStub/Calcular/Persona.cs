namespace Calcular
{
    public class Persona
    {
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public bool SumaCorrecta { get; set; }

        public void Sumar(Calcular calcular)
        {
            int suma = numero1 + numero2;
            if (calcular.DevolverResultado == suma)
            {
                SumaCorrecta = true;
            }
        }
    }
}