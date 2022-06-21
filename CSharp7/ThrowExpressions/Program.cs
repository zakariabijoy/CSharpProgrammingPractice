using System;
using System.Collections.Generic;
using System.Linq;

namespace ThrowExpressions_v7_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee { FirstName = "Joe", LastName = "Smith", IsManager = false, YearsWorked = 2 };
            var emp2 = new Employee { FirstName = "Sandra", LastName = "Jones", IsManager = false, YearsWorked = 28 };
            List<Employee> employees = new List<Employee>() { emp1, emp2 };

            // new way with Throw expressions
            var ceo = employees.Where(x => x.IsManager).FirstOrDefault() ?? throw new Exception("there was a problem finding a manger");

            //old way
                //if (ceo == null)
                //{
                //    throw new Exception("there was a problem finding a manger");
                //}
            
            Console.WriteLine($"the ceo is {ceo.FirstName}");

        }
    }

    internal class Employee
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsManager { get; set; }
        public int YearsWorked { get; set; }
    }
}
