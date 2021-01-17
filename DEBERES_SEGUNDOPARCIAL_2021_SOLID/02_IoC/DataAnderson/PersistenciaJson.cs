using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using Entities;
using Interfaces;
namespace DataAnderson
{
    [Export(typeof(IGrabador))]
    public class PersistenciaJson : IGrabador
    {
        public bool Grabar(Estudiante estudiante)
        {
            try
            {
                estudiante.EstudianteId = new Random().Next(1000, 9999);
                var data = string.Format("{{\"EstudianteId\": \"{0}\",\"Nombre\": \"{1}\",\"Apellido\": \"{2}\"}}"
                    , estudiante.EstudianteId
                    , estudiante.Nombre
                    , estudiante.Apellido);
                System.IO.File.AppendAllLines("Data.json",
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