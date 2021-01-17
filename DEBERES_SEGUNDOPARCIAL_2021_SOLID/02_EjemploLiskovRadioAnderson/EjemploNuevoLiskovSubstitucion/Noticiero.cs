using System;
namespace EjemploNuevoLiskovSubstitucion
{
    class Noticiero : Principal
    {
        public Noticiero(string mensajeRadio): base(mensajeRadio)
        {

        }
        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}",mensaje);
        }
    }
}
