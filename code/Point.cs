using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    internal class Point
    {
        public int ver;
        public int hor;
        public int Length;

        public Point(int a, int b, int Length)
        {
            ver = a;
            hor = b;
            this.Length = Length;
        }
    }
}
