using System;
namespace _02_InyecDepenStructureMap
{
    internal class Mensaje1 : IMensaje
    {
        public string GetMessage()
        {
            return "Buenos días!";
        }
    }
}
