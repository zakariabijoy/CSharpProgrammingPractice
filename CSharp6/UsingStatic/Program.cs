
#region before c# 6


//using System;
//namespace WithoutUsingStatic
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//           Console.WriteLine(Math.Sqrt(3 * 3 + 4 * 4));
//        }
//    }
//}
#endregion


#region Static imports in c# 6

using static System.Console;
using static System.Math;

/// <summary>
/// can access static members of a type without having to qualify the access with the type name in c# 6
/// </summary>
namespace UsingStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Sqrt(3 * 3 + 4 * 4));
        }
    }
}

#endregion


