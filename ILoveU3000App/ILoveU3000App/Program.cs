using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoveU3000App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type i love u 3000");
            string i = Console.ReadLine();
            if (i == "i love u 3000")
            {
                for (int j = 1; j <= 3000; j++)
                {
                    Console.WriteLine("i love u "+j);
                }
            }
            Console.ReadKey();
        }
    }
}
