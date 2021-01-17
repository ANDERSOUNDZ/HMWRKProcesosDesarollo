using System;
namespace _02_InyecDependAutoFact
{
    public class EstudianteRepositorio : IEstudianteRepositorio
    {
        public void Print(Estudiante estudiante)
        {
            Console.WriteLine("Información del estudiante");
            Console.WriteLine(string.Format("id: {0}, nombre: {1}", estudiante.IdEstudiante, estudiante.NombreEstudiante));
        }
    }
}
