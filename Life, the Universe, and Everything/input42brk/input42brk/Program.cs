using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input42brk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 != 1)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i == 42)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }



            }

            Console.ReadLine();

        }
    }
}
