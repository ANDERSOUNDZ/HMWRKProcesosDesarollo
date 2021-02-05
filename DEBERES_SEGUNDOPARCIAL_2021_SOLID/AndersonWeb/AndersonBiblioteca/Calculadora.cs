namespace AndersonBiblioteca
{
    public class Calculadora : IArea
    {
        public int Lado { get; set; }
        public int Resultado { get; set; }

        public int CalcularAreaCuadrado()
        {
            return Resultado = Lado * Lado;
        }
    }
}
