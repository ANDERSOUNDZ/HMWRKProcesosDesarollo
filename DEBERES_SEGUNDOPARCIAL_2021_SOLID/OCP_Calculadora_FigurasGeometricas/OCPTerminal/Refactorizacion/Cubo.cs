namespace OCPTerminal.Refactorizacion
{
    internal class Cubo : IArea
    {
        public double Lado { get; internal set; }

        public double Area()
        {
            return 6 * Lado * Lado;
        }
    } 
}