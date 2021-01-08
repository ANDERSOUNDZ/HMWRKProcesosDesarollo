using System;
namespace SRPejemplos
{
    public class Cuadrado
    {
        //1 Responsabilidad
        public float Lado { get; set; }

        public float PosicionX { get; set; }

        public float PosicionY { get; set; }

        public float Perimetro()
        {
            return Lado * 4;
        }

        public float Superficie()
        {
            return Lado * Lado;
        }

        public void Dibujar()
        {
            //Dibujar el cuadrado
        }

        public void Guardar()
        {
            //Guardar
        }
    }
    
}
