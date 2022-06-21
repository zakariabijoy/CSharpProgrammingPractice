using System;

namespace Read_OnlyStructMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public readonly double Area => (Height * Length);
        public readonly override string ToString() =>
            $"(Total area for height: {Height}, width: {Length}) is {Area}";
    }
}
