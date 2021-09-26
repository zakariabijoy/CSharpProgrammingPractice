using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            (int x, int y)[] points = new (int x, int y)[100];

            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    points[count++] = (1,2);
                }
            }

            int r= 0;
            for (int i = 0; i < count; i++)
            {
                r += (points[i].x * points[i].y + points[i].y / points[i].x);
            }

            (string[] data, int count) myData = GetData();
            Console.WriteLine( myData.count);

            foreach (var item in myData.data)
            {
                Console.WriteLine(item);
            }
        }
        static (string[] data, int count) GetData()
        {
            string[] r = new string[] {"sda","dad" };
            int c = 20;
            return (r,c);
        }
    }
}
