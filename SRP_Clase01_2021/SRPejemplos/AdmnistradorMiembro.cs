using System;

namespace SRPejemplos
{

    public class AdministradorMiembro
    {
        public void Aumentar(miembro miembro)
        {
            
        }

        public void Aumentar(String nombre, String apellido, String cedula)
        {
            try
            {
                //Aqui va nuestro codigo
                System.IO.File.AppendAllText("\\datos\\data.txt", String.Format("nombre:{0},apellido:{1},cedula:{2}", nombre,apellido,cedula));
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.Fail(ex.Message);
            }
        }

        public void Eliminar()
        {
            //Aqui va el codigo
        }
    }
}
