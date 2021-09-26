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
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();  // getting a list of IProductModel type data
            CustomerModel customer = GetCustomer();     // getting a customer

            foreach (IProductModel prod in cart)    // using ShipItem method which is implemented in from IProductModel interface
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }


            DemoClass myObj = new DemoClass();  // Creating object of multiple interface implemented class
            myObj.MyMethod();  // this method implemented from IFirstInterFace
            myObj.MyOtherMethod();   // this method implemented from ISecondInterFace

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel  // creating object and initialize value and return 
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        /// <summary>
        /// creating list of object of IProductModel type  and returning List<IProductModel> after adding data of different model ( implemented IProduct Model Interface) to list
        /// </summary>
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();     

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Lesson Source Code" });
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish" });

            return output;
        }
    }
}
