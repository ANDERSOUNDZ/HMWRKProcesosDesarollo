using System;

namespace LiskovEjemplo
{
    public class CongeLador : InterfaceCongelar
    {
        public string modelo { get; set; }
        public string tipo { get; internal set; }
        public string marca { get; internal set; }

        //Acciones que tiene Un Aparato Especifico
        public void Congelar()
        {
            Console.WriteLine(this.modelo);
        }
        
    }
}