#region before c# 6

//using System;

///// <summary>
///// before c# 6 we generally used constructor to initialize the value of the Property
///// </summary>
//namespace WithoutAutoPropertyInitializer
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            Console.WriteLine("Employee Id is " + emp.EmployeeId);
//            Console.WriteLine("Employee Full Name is " + emp.FullName);
//            Console.ReadLine();
//        }
//    }
//    public class Employee
//    {
//        public Guid EmployeeId{get; set;}

//        public string FirstName{get;set;}

//        public string LastName{get;set;}

//        public string FullName{ get;set;}

//        public Employee()
//        {
//            EmployeeId = Guid.NewGuid();
//            FirstName = "Mukesh";
//            LastName = "Kumar";
//            FullName = string.Format("{0} {1}", FirstName, LastName);
//        }
//    }
//}
#endregion


#region AutoPropertyInitializer in c# 6

using System;
using static System.Console;

/// <summary>
/// You can directly assign the value of the property after = sign in c# 6
/// </summary>
namespace AutoPropertyInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            WriteLine("Employee Id is " + emp.EmployeeId);
            WriteLine("Employee Full Name is " + emp.FullName);
            ReadLine();
        }

        public class Employee
        {
            public Guid EmployeeId{get;set;} = Guid.NewGuid();
            public string FirstName{get;set;} = "Mukesh";
            public string LastName{get;set;} = "Kumar";

            public string FullName
            {
                get
                {
                    return string.Format("{0} {1}", FirstName, LastName);
                }
            }
        }
    }
}

#endregion

