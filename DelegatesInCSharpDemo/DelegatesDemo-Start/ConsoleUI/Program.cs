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
        static ShoppingCartModel cart = new ShoppingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"the total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLevelDiscount, AlertUser):C2}");
            var total = cart.GenerateTotal((subTotal) => Console.WriteLine($"the subtotal is for cart 2  {subTotal:C2}"),
                                            (items, subtotal) => {
                                                if (subtotal > 100)
                                                {
                                                    return subtotal * 0.80M;
                                                }
                                                else if (subtotal > 50)
                                                {
                                                    return subtotal * 0.85M;
                                                }
                                                else if (subtotal > 10)
                                                {
                                                    return subtotal * 0.95M;
                                                }
                                                else
                                                {
                                                    return subtotal;
                                                }
                                            }  ,
                                            (message) => Console.WriteLine(message));

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        private static void SubTotalAlert(decimal subtotal)
        {
            Console.WriteLine($"the subtotal is {subtotal:C2}");
        }

        private static decimal CalculateLevelDiscount(List<ProductModel> items, decimal subtotal)
        {
            if (subtotal > 100)
            {
                return subtotal * 0.80M;
            }
            else if (subtotal > 50)
            {
                return subtotal * 0.85M;
            }
            else if (subtotal > 10)
            {
                return subtotal * 0.95M;
            }
            else
            { 
                return subtotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
