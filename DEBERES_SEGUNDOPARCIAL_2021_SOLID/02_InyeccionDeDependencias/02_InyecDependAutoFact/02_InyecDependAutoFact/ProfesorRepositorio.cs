using System;
namespace _02_InyecDependAutoFact
{
    public class ProfesorRepositorio : IProfesorRepositorio
    {
        public void Print(Profesor profesor)
        {
            Console.WriteLine("Información del profesor");
            Console.WriteLine(string.Format("id: {0}, nombre: {1}", profesor.IdProfesor, profesor.NombreProfesor));
        }
    }
}
