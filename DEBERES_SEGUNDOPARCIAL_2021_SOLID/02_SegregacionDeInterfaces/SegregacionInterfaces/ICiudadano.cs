using System;

namespace SegregacionInterfaces
{
    public interface ICiudadano
    {
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Genero { get; set; }
        string OrientacionSexual { get; set; }
        string IdentidadCultural { get; set; }

        //int PagarImpuestos(int año);
        //double PagarImpuestoPredial(int año, Propiedad propiedad);
        //double PagarImpuestoVerde(int año, Vehiculo propiedad);
        //double PagoLuz(DateTime fecha, Propiedad propiedad);
        //double PagoAgua(DateTime año, Propiedad propiedad);
        //string ExigirDerecho(string derecho);
        //string CumplirDeber(string deber);
        //string AcatarLey(string ley);
        //string ExpresarOpinion(string opinion);
        //string Sufragar(Votacion votacion);
        //string Postular(string Candidatura);
        //string Afiliar(PartidoPolitico partidoPolitico);
    }
}
