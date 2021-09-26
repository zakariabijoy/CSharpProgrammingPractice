using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_hiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullname ()
        {
            Console.WriteLine(FirstName + " " + LastName); 
        }
    }
    public class partTimeEmployee : Employee
    {
        public new void PrintFullname()
        {
         
            Console.WriteLine(FirstName + " " + LastName + "- constractor");
        }
    }
    public class FullTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullname();

           Employee  PTE = new partTimeEmployee ();
            PTE.FirstName = "PARTtime";
            PTE.LastName = "Employee";
            PTE.PrintFullname();




        }
    }
}
