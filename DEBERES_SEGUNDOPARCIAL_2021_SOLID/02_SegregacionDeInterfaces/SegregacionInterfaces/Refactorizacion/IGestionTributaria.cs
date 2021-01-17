using System;
namespace SegregacionInterfaces.Refactorizacion
{
    //Los tributos son ingresos de derecho público​ que consisten​ en prestaciones pecuniarias obligatorias
    //impuestas unilateralmente por el Estado, exigidas por una administración pública como consecuencia de
    //la realización del hecho imponible al que la ley vincule en el deber de contribuir.
    interface IGestionTributaria
    {
        int PagarImpuestos(int año);
        double PagarImpuestoPredial(int año, Propiedad propiedad);
    }
}
