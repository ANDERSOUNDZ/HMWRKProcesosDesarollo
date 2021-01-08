using System;
namespace SRPejemplos.SRP
{
    public class Geometria
    {
        public float Perimetro(float lado)
        {
            return lado * 4;
        }

        public float Superficie(float lado)
        {
            return lado * lado;
        }

        public float Volumen(float lado)
        {
            return 2*(lado)+2*(lado);
        }
    }
}
