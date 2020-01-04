using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    /// Given two numbers number1 and number2. find the position of rightmost different bit in binary representation of these numbers
    /// </summary>
    public class RightMostDifferentBit
    {
        /// <summary>
        /// xor sets the bit where deviation is there.
        /// So take xor and then find the right most set bit
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int GetRightMostDifferentBit(int number1, int number2)
        {
            if (number1 == number2)
                return -1;
            RightMostSetBit rightMostSetBit = new RightMostSetBit();

            return rightMostSetBit.GetRightMostSetBit1(number1 ^ number2);
        }
    }
}
