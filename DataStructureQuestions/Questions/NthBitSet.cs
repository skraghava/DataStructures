using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    /// Check to see if Nth bit (From Right) is set or not in binary representation of a given number
    /// </summary>
    public class NthBitSet
    {
        public bool IsNthBitSet(int number, int position)
        {
            if (position > 32 || position < 1)
                return false;
            return (number & (1 << position-1)) > 0;
        }
    }
}
