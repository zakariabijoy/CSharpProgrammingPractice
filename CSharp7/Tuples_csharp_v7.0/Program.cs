using System;

namespace TupleAndDeconstruction_csharp_v7._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = SpliteName("Zakaria Masud");
            Console.WriteLine($"The firstName is {name.firstName} and the last name is {name.LastName}");


            //Deconstruction (splitting tuples)
            (string firstName, string lastName) = SpliteName("zakaria bijoy");
            Console.WriteLine($"The firstName is {firstName} and the last name is {lastName}");
        }

        public static (string firstName, string LastName) SpliteName(string fullName)
        {
            string[] vals = fullName.Split(' ');
            return (vals[0], vals[1]);
        }
    }
}
