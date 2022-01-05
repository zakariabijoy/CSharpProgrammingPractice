using System;
using static System.Console;


/// <summary>
/// C# 6.0 is not required to create separate methods for only a single task.
/// It can be defined and completed at that time, when it is defining.
/// </summary>
namespace ExpressionBodiedMembers
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string firstName = "Mukesh";
            string lastName = "Kumar";
            int firstNumber = 10;
            int secondNumber = 20;

            WriteLine(GetFullName(firstName, lastName));
            WriteLine(AddTwoNumber(firstNumber, secondNumber));
            ReadLine();
        }

        public static string GetFullName(string firstName, string lastName) => firstName + " " + lastName;
        public static int AddTwoNumber(int firstNumber, int secondNumber) => firstNumber + secondNumber;
    }
}
