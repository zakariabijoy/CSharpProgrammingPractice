using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_six
{
    class Circle
    {
        float pi = 3.1416f;
        int _radius;
        public Circle(int Radius)
        {
            this._radius = Radius;
                

        }
        public float calculateArea()
        {
            return this.pi * this._radius * this._radius;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Area1 = c1.calculateArea();
            Console.WriteLine("Area={0}", Area1);

            Circle c2 = new Circle(6);
            float Area2 = c2.calculateArea();
            Console.WriteLine("Area={0}", Area2);

                

        }
    }
}
