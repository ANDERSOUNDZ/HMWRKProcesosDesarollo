using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Entities;
using Interfaces;
using DataAnderson;

namespace IoC
{
    class Program
    {
        private readonly CompositionContainer contenedor;

        //Constructor
        private Program()
        {
            var catalogo = new AggregateCatalog();
            catalogo.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));

            contenedor = new CompositionContainer(catalogo);
            
            try
            {
                contenedor.ComposeParts(this);
            }
            catch(CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        //Encapsulamiento
        [Import(typeof(IGrabador))]
        public IGrabador Persistencia { get; set; }

        static void Main(string[] args)
        {
            var programa = new Program();
            programa.RealizarTrabajo();
        }

        public void RealizarTrabajo()
        {
            Console.WriteLine("Inversion de control");
            var persistencia = new PersistenciaJson();

            var estudiante = new Estudiante
            {
                Nombre = "Anderson",
                Apellido = "Chanchay"
            };

            if (persistencia.Grabar(estudiante))
            {
                Console.WriteLine("Se grabo!");
            }
        }
    }
}