#region concatenation before c# 6

//using System;

//namespace WithoutStringInterpolation
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            string firstName = "Mukesh";
//            string lastName = "Kumar";

//            Console.WriteLine("The Full Name of Employee " + string.Format("{0} {1}", firstName, lastName));
//            Console.ReadLine();
//        }
//    }
//}
#endregion



#region concatenation  in c# 6 with StringInterpolation

using System;

using static System.Console;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mukesh";
            string lastName = "Kumar";

            WriteLine($"The Full Name of Employee {firstName} {lastName}");
            ReadLine();
        }
    }
}

#endregion

