﻿using System;
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
            int i = 1;
            while (i >= 1)
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i == 42)
                    break;

                Console.WriteLine(i + "");
                Console.ReadKey();
            }
        }
    }
}


