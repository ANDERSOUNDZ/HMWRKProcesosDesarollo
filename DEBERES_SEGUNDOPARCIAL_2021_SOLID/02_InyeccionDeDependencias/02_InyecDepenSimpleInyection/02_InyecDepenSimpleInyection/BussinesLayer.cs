﻿namespace _02_InyecDepenSimpleInyection
{
    public class BussinessLayer
    {
        private ICart _objcart;
        public BussinessLayer(ICart objcart)
        {
            _objcart = objcart;
        }
        public void InserttoCart()
        {
            _objcart.AddtoCart();
        }
    }
}
