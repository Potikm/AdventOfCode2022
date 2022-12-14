using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    internal class Point
    {
        public int X;
        public int Y;
        public int Length;

        public Point(int a, int b, int Length)
        {
            X = a;
            Y = b;
            this.Length = Length;
        }
    }
}
