using StructureMap;

namespace _02_InyecDepenStructureMap
{
    internal class Contenedor
    {
        internal static IContainer InitContainer()
        {
            var container = new Container(c => c.For<IMensaje>().Use<Mensaje2>());

            return container;
        }
    }
}
