using System;

namespace EjemploNuevoLiskovSubstitucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Noticiero");

            Principal miNoticiero = new Noticiero("Hola a Todos");
            miNoticiero.Muestra();

            Principal miRadio = new Radio("Como estan");
            miRadio.Muestra();

        }
    }
}
