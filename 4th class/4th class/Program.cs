using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, e;
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
           
            
            calculation ocale = new calculation();

         int a= ocale.sum(1, 2);

         Console.WriteLine(a);


        }


       
    }
}
