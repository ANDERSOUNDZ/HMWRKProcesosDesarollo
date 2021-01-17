using System;
namespace SegregacionInterfaces
{
    class EstudianteSecundario : Estudiante
    {
        public new string Sufragar(Votacion votacion)
        {
            if (DateTime.Now.Subtract(FechaNacimiento).TotalDays < 16*365)
            {
                return "No puedo votar";
            }
            return base.Sufragar(votacion);
        }

        public new double PagoImpuestoRenta(int año)
        {
            throw new NotImplementedException("Este metodo no puede implemntar estudiante");
        }
    }
}
