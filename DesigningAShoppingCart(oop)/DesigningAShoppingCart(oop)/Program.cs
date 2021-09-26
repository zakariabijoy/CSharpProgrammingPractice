using System;

namespace DesigningAShoppingCart_oop_
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();
            cart.AddItem(new CartItem(new Product { Name = "laptop", Price = 500, ImageFileName = "laptop.jpg" }));
            cart.AddItem(new CartItem(new Product { Name = "mobile", Price = 100, ImageFileName = "mobile.jpg" }));
            cart.AddItem(new CartItem(new GiftCard { Name = "50 coupon", Price = 50, ImageFileName = "coupon.jpg" }));

            cart["laptop"].UpdateQuantity(5);
            cart["50 coupon"].UpdateQuantity(3);

            foreach (var item in cart.Items)
            {
                Console.WriteLine($"{item.Item.Name}, {item.Quantity}");
            }
            Console.WriteLine(cart.Total);
        }
    }
}
