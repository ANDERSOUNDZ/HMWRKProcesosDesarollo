using System;
namespace SegregacionInterfaces.Refactorizacion
{
    class AdultoMayor : IDerechoProcesal, IGestionTributaria
    {
        public int idDerechoProcesal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int idLey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string opinion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string AcatarLey(string ley)
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
    }
}
