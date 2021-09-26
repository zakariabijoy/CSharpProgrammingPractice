using System;
using System.Collections.Generic;

namespace InterfaceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Item[] { new Item(1,"a"), new Item (2,"b") };


            ShopingCart cart = new ShopingCart(items);
            foreach (Item item in cart) // we can loop cart cause we implemnet Ienumarable
            {
                Console.WriteLine(item.Name);
            }
            //ShopingCart cart2 = (ShopingCart)cart.Clone(); // we can pass new shoping cart object with cart value beacause we implement ICloneable

            //using var cart3 = new ShopingCart(); // we can dipose by using keyword cause we Implement IDisposable 

            //cart3.Dispose(); // we can dipose by call dispose method cause we Implement IDisposable 



        }
    }
}
