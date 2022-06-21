using System;

namespace PatternMatching_csharp_v7._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ageFromConsole = "21";
            int ageFromDatabase = 64;

            object ageVal = ageFromConsole;

            if(ageVal is int age || (ageVal is string ageText && int.TryParse(ageText,out age)))
            {
                Console.WriteLine($"Your age is {age}");
            }
            else
            {
                Console.WriteLine("we do not know your age");
            }
        }
    }
}
