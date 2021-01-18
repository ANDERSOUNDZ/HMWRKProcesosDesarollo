using System;
namespace _02_InyecDepenSimpleInyection
{
    public class DataAccessLayer : ICart
    {
        public string AddtoCart()
        {
            string val = "Juan ";
            string obj = "Automóvil"; ;
            Console.WriteLine(val);
            Console.WriteLine(obj);
            return string.Format(" {0} {1}", val, obj);
        }
    }
}
