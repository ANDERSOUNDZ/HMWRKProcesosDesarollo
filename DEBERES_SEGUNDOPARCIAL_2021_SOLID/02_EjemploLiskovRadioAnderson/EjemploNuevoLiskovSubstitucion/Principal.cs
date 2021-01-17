using System;
namespace EjemploNuevoLiskovSubstitucion
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensajeRadio)
        {
            mensaje = mensajeRadio;
        }

        public abstract void Muestra();
    }
}
