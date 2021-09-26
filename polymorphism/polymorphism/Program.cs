using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
            public string LastName = "LN";
        public virtual  void PrintFullName()
        {
            Console.WriteLine(FirstName + " "+ LastName);
        }
    }
    public class parttimeEmployee:Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName +"- part time ");
        }
    }
    public class fulltimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- full time ");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- temporary time ");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
           Employee[] employees = new Employee[4];

           employees[0] = new Employee();
           employees[1] = new parttimeEmployee();
           employees[2] = new fulltimeEmployee();
           employees[3] = new TemporaryEmployee();
           foreach (Employee e in employees)
           {
               e.PrintFullName();
           }
           }
    }
}

