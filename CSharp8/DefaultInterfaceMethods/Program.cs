using System;


/// <summary>
/// Extend interfaces safely by adding methods with implementations.
/// Create parameterized implementations to provide greater flexibility.
/// Enable implementers to provide a more specific implementation in the form of an override.
/// </summary>

namespace DefaultInterfaceMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShoppingCart cart1 = new ShoppingCart();
            cart1.CalculateSubTotal();

            IShoppingCart cart2 = new BetterShoppingCart();
            cart2.CalculateSubTotal();

            cart1.CalculateSubTotal();
        }
    }


    // 1.The main scenario of Default Interface Methods is is to add new members to an existing interface which is already in production. 
    // 2 . it allows you to write less code during implementation and common code of different derived classes can be written directly in the interface, an alternate of abstract class.
    public interface IShoppingCart
    {
        public static void SetDefaultName(string name)
        {
            defaultName = name; 

        }

        private static string defaultName = "default";
        void CalculateSubTotal()
        {
            Console.WriteLine($"this is CalculateSubTotal {defaultName} Interface Methods in the Ishoppingcart interface");
        }
        void CalculateTotal();
    }

    public class ShoppingCart : IShoppingCart
    {
        public void CalculateTotal()
        {
            Console.WriteLine("this is calculateTotal in the shoppingcart class");
        }
    }

    public class BetterShoppingCart : IShoppingCart
    {
        public BetterShoppingCart()
        {
            IShoppingCart.SetDefaultName("DefaultBetterShoppingCart");
        }
        public void CalculateTotal()
        {
            Console.WriteLine("this is calculateTotal in the BetterShoppingCart class");
        }
        //public void CalculateSubTotal()
        //{
        //    Console.WriteLine("this is override of CalculateSubTotal (Default Interface Methods) in the BetterShoppingCart class");
        //}
    }
}
