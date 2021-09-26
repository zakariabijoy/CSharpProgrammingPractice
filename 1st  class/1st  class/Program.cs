using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1st__class
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("please put the value of a,b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int sum,sub;
            sum = a+b;
            sub = a-b;
            Console.WriteLine("sum is {0}{1}",sum,sub);
            Console.ReadKey();




            //int i = 0;
            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("you press 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("you press 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("you press 3");
            //        break;
            //    case default:
            //        Console.WriteLine("you press 3");
            //        break;
                
            //}
            
        }
    }
}
