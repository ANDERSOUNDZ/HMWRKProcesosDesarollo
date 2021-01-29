namespace Aplicante
{
    public class Persona
    {
        public bool PostulaTrabajo { get; set; }

        public void EnviaCurriculum(Empleo empleo, string area)
        {
            if (empleo.EmpleoDisponible  == area)
            {
                PostulaTrabajo = true;
            }
        }
    }
}