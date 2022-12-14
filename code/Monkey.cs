using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class Monkey
    {

        public List<int> nums = new List<int>();
        public int counter = 0;

        public Monkey(List<int> nums)
        {
            this.nums = nums;
        }
    }
}
