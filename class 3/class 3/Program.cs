using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, e;
            d =  Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            int s = sum(d, e);
            Console.WriteLine(s);
            
         

        }


        public static int sum(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

             




    
    }
}