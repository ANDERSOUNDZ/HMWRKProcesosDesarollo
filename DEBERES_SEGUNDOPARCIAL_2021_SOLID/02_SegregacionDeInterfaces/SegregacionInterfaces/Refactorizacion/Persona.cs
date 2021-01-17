using System;
namespace SegregacionInterfaces.Refactorizacion
{
    class Persona : IElectoral,IServiciosBasicos, IGestionTributaria, IDerechoProcesal
    {
        public string ci { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nombrePartidoPolitico { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int idPropiedad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int idDerechoProcesal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int idLey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string opinion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string AcatarLey(string ley)
        {

            throw new NotImplementedException();
        }

        public string Afiliar(PartidoPolitico partidoPolitico)
        {
            throw new NotImplementedException();
        }

        public string CumplirDeber(string deber)
        {
            throw new NotImplementedException();
        }

        public string ExigirDerecho(string derecho)
        {
            throw new NotImplementedException();
        }

        public string ExpresarOpinion(string opinion)
        {
            throw new NotImplementedException();
        }

        public double PagarImpuestoPredial(int año, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public int PagarImpuestos(int año)
        {
            throw new NotImplementedException();
        }

        public double PagoAgua(DateTime año, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public double PagoLuz(DateTime fecha, Propiedad propiedad)
        {
            throw new NotImplementedException();
        }

        public string Postular(string Candidatura)
        {
            throw new NotImplementedException();
        }

        public string Sufragar(Votacion votacion)
        {
            throw new NotImplementedException();
        }
    }
}
