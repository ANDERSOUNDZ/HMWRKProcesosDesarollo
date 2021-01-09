namespace OCPTerminal.Refactorizacion

{
    internal class Triangulo : IArea
    {
        public double Base { get; internal set; }
        public double Altura { get; internal set; }

        public double Area()
        {
            return this.Base * this.Altura / 2;
        }
        
    }
}