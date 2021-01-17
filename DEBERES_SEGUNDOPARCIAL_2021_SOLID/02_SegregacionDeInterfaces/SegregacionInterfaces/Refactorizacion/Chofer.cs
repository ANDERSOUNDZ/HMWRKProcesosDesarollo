using System;
namespace SegregacionInterfaces.Refactorizacion
{
    class Chofer : ITributoTransporte, IDerechoProcesal
    {
        public int idDerechoProcesal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int idLey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string opinion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string AcatarLey(string ley)
        {
            throw new NotImplementedException("El condictor acata la ley");
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

        public double PagarImpuestoVerde(int año, Vehiculo propiedad)
        {
            throw new NotImplementedException();
        }
    }
}
