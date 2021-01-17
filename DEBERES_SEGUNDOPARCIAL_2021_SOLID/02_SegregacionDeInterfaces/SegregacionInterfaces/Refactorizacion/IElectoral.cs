using System;
namespace SegregacionInterfaces.Refactorizacion
{
    public interface IElectoral
    {
        public string ci { get; set; }
        public string nombre { get; set; }
        public string nombrePartidoPolitico { get; set; }

        string Postular(string Candidatura);
        string Afiliar(PartidoPolitico partidoPolitico);
        string Sufragar(Votacion votacion);
    }
}
