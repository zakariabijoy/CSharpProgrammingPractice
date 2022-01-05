using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenstionMethod
{
    public static class ExtenstionMethods
    {
        public static int Sum(this int x, int y)
        {
            return x + y;
        }
        public static int Sum(this int u, int y, int z)
        {
            return u + y+z;
        }

        public static int Mul(this int u, int y, int z)
        {
            return u * y * z;
        }
    }
}
