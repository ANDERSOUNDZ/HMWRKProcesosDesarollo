using System.Collections.Generic;

namespace NSubtitute
{
    public class Bodega : IBodega
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        internal void Add(string producto, int cantidad)
        {
            dic.Add(producto, cantidad);
        }

        public void ActualizarExistencia(string producto, int cantidad)
        {
            if (dic.ContainsKey(producto))
            {
                dic[producto] = cantidad;
            }
            else
            {
                Add(producto, cantidad);
            }
        }

        public int Existencia(string producto)
        {
            if (dic.ContainsKey(producto))
            {
                return dic[producto];
            }
            return 0;
        }
    }
}