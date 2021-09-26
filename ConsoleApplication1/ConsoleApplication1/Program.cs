using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input the value of i");
            int i = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            for (; i < 10; i++)
            {
                Console.WriteLine("The value is{0}\{1}",i,b);

            }
            Console.ReadLine();
        }
    }
}
