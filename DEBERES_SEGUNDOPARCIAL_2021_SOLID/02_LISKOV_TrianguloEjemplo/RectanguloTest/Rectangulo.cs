using RectanguloTest;

namespace LiskovTest
{
    internal class Rectangulo : IArea
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Rectangulo() { }

        public Rectangulo(int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public double Area()
        {
            return Ancho * Alto;
        }
    }
}