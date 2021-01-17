using System;
namespace SegregacionInterfaces.Refactorizacion
{
    public interface IServiciosBasicos
    {
        public int idPropiedad { get; set; }

        double PagoLuz(DateTime fecha, Propiedad propiedad);
        double PagoAgua(DateTime año, Propiedad propiedad);
    }
}
