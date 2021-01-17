using System;
using System.Reflection;
using Ninject;

namespace _02_InyecDepenNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Injecion de dependencia Ninject!");

            StandardKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            ILibrero _objetoLibrero = _Kernal.Get<ILibrero>();
            Libro objetoLibro = new Libro(_objetoLibrero);
            objetoLibro.IngresoLibro();
            Console.ReadLine();
        }
    }
}
