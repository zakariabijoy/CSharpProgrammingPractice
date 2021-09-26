using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();  // create object of ShoppingCartModel

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();     //seedind data to cart object

            // passing three methods as  arguments with corresponding signature of delegate
            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");
            Console.WriteLine();

            //// passing three Lambda Expression   as  arguments with corresponding signature of delegate
            decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"The subtotal for cart 2 is {subTotal:C2}"),
                (products, subTotal) => {
                    if (products.Count > 3)
                    {
                        return subTotal * 0.5M;
                    }
                    else
                    {
                        return subTotal;
                    }
                },
                (message) => Console.WriteLine($"Cart 2 Alert: { message }"));

            Console.WriteLine($"The total for cart 2 is {total:C2}");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
           
        }

        private static void SubTotalAlert(decimal subTotal) //method with corresponding signature of delegate
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void AlertUser(string message) //method with corresponding signature of delegate
        {
            Console.WriteLine(message);
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal) //method with corresponding signature of delegate
        {
            {
                if (subTotal > 100)
                {
                    return subTotal * 0.80M;
                }
                else if (subTotal > 50)
                {
                    return subTotal * 0.85M;
                }
                else if (subTotal > 10)
                {
                    return subTotal * 0.95M;
                }
                else
                {
                    return subTotal;
                }
            }
        }

        private static void PopulateCartWithDemoData()   // method for seeding data to cart model
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        } 
    }
}
