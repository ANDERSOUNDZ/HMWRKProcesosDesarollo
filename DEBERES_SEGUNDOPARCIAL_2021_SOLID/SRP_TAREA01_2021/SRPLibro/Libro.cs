using System;

namespace SRPLibro
{
    public class EmpastadoLibro
    {
        public Guid id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string AñoPublicacion { get; set; }
        public string Editorial { get; set; }
    }

    public class LibroAcciones
    {
        public void GuardarLibroBD(int id)
        {
            
        }

        public void EditarLibroBD(int id)
        {

        }

        public void EliminarLibroBD(int id)
        {
            
        }

    }

}

