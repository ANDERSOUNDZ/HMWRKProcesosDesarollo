using System;
namespace SegregacionInterfaces.Refactorizacion
{
    //El derecho procesal es el conjunto de
    //normas que regulan el proceso judicial, es decir, que regula los requisitos, el desarrollo y los efectos del proceso.
    interface IDerechoProcesal
    {
        public int idDerechoProcesal { get; set; }
        public int idLey { get; set; }
        public string opinion { get; set; }

        string ExigirDerecho(string derecho);
        string CumplirDeber(string deber);
        string AcatarLey(string ley);
        string ExpresarOpinion(string opinion);
    }
}
