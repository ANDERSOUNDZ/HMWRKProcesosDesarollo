using System;
using Castle.Windsor;

namespace _02_InyecDepenCastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inyeccion de dependencias Castle Windsor!");
            //Proceso de Ingreso de dependencias
            var container = new WindsorContainer();
            container.Register(Castle.MicroKernel.Registration.Component.For<Persona>());
            container.Register(Castle.MicroKernel.Registration.Component.For<INombre>().ImplementedBy<Nombre>());
            container.Register(Castle.MicroKernel.Registration.Component.For<IApellido>().ImplementedBy<Apellido>());

            var persona = container.Resolve<Persona>();
            Console.WriteLine("Hola, {0}!", persona.NombreCompleto());

        }
    }
}
