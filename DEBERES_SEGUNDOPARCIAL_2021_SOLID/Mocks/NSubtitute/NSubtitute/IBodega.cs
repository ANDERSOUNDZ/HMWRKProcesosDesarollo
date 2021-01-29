using System;
namespace NSubtitute
{
    public interface IBodega
    {
        int Existencia(string producto);
        void ActualizarExistencia(string producto, int cantidad);
    }
}
