using System;
using System.Collections.Generic;

namespace LiskovEjemplo
{
    public class Electrodomestico
    {
        public string tipo = "Electrodomestico";
        public string marca { get; set; }

        public virtual void Congelar()
        {
            Console.WriteLine(this.tipo, this.marca);
        }

        //Devuelve solo los equipos Congeladores
        public void Congelando(List<InterfaceCongelar> congeladores)
        {
            foreach (var congelador in congeladores)
            {
                congelador.Congelar();
            }
        }
    }
}