using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using static MEF.Program;

namespace MEF
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MEF");

            // Composition is performed in the constructor.
            var CalculadoraPrincipal = new Program();
            string IngresoDatos;
            Console.WriteLine("Enter Command:");
            while (true)
            {
                IngresoDatos = Console.ReadLine();
                Console.WriteLine(CalculadoraPrincipal.calculator.Calculate(IngresoDatos));
            }
        }

        private CompositionContainer _container;

        private Program()
        {
            // An aggregate catalog that combines multiple catalogs.
            var catalog = new AggregateCatalog();
            // Adds all the parts found in the same assembly as the Program class.
            //Revisar
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));

            // Create the CompositionContainer with the parts in the catalog.
            _container = new CompositionContainer(catalog);

            // Fill the imports of this object.
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        [Import(typeof(ICalculator))]
        public ICalculator calculator;

    }
}
