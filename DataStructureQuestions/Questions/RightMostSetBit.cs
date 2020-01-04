using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    /// <summary>
    /// Different ways of finding the right most set bit for given integer number
    /// </summary>
    public class RightMostSetBit
    {
        /*  Additional Notes
         C# int is 32 bit
         Negative numbers are represented using 2's complement

         */
        public int GetRightMostSetBit1(int number)
        {

            return number == 0 ? 0 : (int)Math.Log(number & -number, 2) + 1;
        }
    }
}
