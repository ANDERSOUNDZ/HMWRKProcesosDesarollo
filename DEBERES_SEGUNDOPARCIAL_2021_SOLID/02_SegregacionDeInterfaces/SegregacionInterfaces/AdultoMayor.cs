using System;
namespace SegregacionInterfaces
{
    class AdultoMayor : ICiudadano
    {
        public string Cedula { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Genero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OrientacionSexual { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdentidadCultural { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public double PagarImpuestoVerde(int año, Vehiculo propiedad)
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
