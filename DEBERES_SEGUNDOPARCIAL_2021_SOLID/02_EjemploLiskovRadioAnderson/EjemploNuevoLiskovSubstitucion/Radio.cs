using System;
namespace EjemploNuevoLiskovSubstitucion
{
    class Radio : Principal
    {
        public Radio(string mensajeRadio): base(mensajeRadio)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde la radio : {0}", mensaje);
        }
    }
}
