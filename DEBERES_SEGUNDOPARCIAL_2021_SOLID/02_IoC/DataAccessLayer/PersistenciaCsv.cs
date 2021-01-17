using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Interfaces;


namespace DataAccessLayer
{
    public class PersistenciaCSV : IGrabador 
    {
        public bool Grabar(Estudiante estudiante)
        { 
            //TODO
            try
            {
                estudiante.EstudianteId = new Random().Next(1000, 9999);
                var data = string.Format("EstudianteId: {0},Nombre: {1}, Apellido:{2}"
                    , estudiante.EstudianteId
                    , estudiante.Nombre
                    , estudiante.Apellido);
                System.IO.File.AppendAllLines("Data.csv",
                new List<string>
                {
                    data
                },
                Encoding.UTF8);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}