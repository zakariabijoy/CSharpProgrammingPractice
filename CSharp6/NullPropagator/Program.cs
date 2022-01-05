using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace NullPropagator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            //No need to check null in if condition  
            //null operator ? will check and return null if value is not there  
            WriteLine(employees.FirstOrDefault()?.Name);

            ReadLine();
        }
    }

    public class Employee
    {
        public int EmployeeId{ get;set;}
        public string Name{ get; set;}
        public string Address{get;set;}

    }
}
