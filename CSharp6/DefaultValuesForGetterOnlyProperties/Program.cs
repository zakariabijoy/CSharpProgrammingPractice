using System;

namespace DefaultValuesForGetterOnlyProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine(obj.MyProp);
            Console.ReadKey();
        }
    }

    public class MyClass
    {
        public int MyProp { get; }

        public MyClass()
        {
            MyProp = 10;
        }
    }
}
