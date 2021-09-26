
using NewProject.TeamB;
using System;
using NewProject.TeamA;

namespace ConsoleApplication5
{
    class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Laptop obj1 = new Laptop();
            obj1.Print();
            Mouse obj2 = new Mouse();
            obj2.Print();
            Console.ReadKey();

        }
    }
}

namespace NewProject
{
    namespace TeamA
    {
        class Laptop
        {
            public void Print()
            {
                Console.WriteLine("Display Laptop");

            }
        }
    }

    namespace TeamB
    {
        class Mouse
        {
            public void Print()
            {
                Console.WriteLine("Display Mouse");
            }
        }

    }
}