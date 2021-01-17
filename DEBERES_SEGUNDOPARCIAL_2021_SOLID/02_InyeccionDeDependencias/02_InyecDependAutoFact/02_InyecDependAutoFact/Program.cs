using System;
using Autofac;

namespace _02_InyecDependAutoFact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inuyeccion de dependencias con Autofact");
            Estudiante estudiante = new Estudiante
            {
                IdEstudiante = 1,
                NombreEstudiante = "Anderson Chanchay"
            };
            Profesor profesor = new Profesor
            {
                IdProfesor = 2,
                NombreProfesor = "Gorky Estrella"
            };

            var container = BuildContainer();

            var estudianteRepositorio = container.Resolve<IEstudianteRepositorio>();
            estudianteRepositorio.Print(estudiante);

            var profesorRepositorio = container.Resolve<IProfesorRepositorio>();
            profesorRepositorio.Print(profesor);

            Console.ReadLine();
        }

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<EstudianteModulo>();
            builder.RegisterModule<ProfesorModulo>();
            return builder.Build();
        }
    }
}
