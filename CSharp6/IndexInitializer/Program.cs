#region before c# 6

//using System;
//using System.Collections.Generic;

///// <summary>
///// C# 6.0 provides a new way to initialize the collection.
///// You can create the index based collections like dictionaries, hashtables etc.
///// As we know, the dictionary is the key-value pair and we need to assign the values for their corresponding keys.
///// We have a different way to create the key/value pair prior to C# 6.0.
///// How we used the key/value pair for a dictionary object in C# prior to C# 6.0 is displayed, with the help of the following example
///// </summary>
//namespace WithoutIndexInitializer
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
//            {
//                {
//                 1,
//                 "Mukesh Kumar"
//                }, 
//                {
//                 2,
//                 "Rahul Rathor"
//                }, 
//                {
//                 3,
//                 "Yaduveer Saini"
//                }, 
//                {
//                 4,
//                 "Banke Chamber"
//                }
//            };

//            foreach (var item in myDictionary)
//            {
//                Console.WriteLine("The " + item.Key + " Number Employee is " + item.Value + "\n");
//            }
//            Console.ReadLine();
//        }
//    }
//}
#endregion




#region IndexInitializer in c# 6

using System;
using System.Collections.Generic;
using static System.Console;

/// <summary>
/// With C# 6.0, we logically define that the value for an index 1 is "Mukesh Kumar" and so on.
/// </summary>
namespace IndexInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                [1] = "Mukesh Kumar",
                [2] = "Rahul Rathor",
                [3] = "Yaduveer Saini",
                [4] = "Banke Chamber"
            };

            foreach (var item in myDictionary)
            {
                WriteLine("The " + item.Key + " Number Employee is " + item.Value + "\n");
            }
            ReadLine();
        }
    }
}
#endregion

