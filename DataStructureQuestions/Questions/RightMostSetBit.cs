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

        /// <summary>
        ///  number & (bitwise and) -number sets 0 for all bits except right most bit and it will always be 2^n like 1,2,4,8.
        ///  Taking log of base 2 for the above number gives n , + 1 is added to adjust the position
        ///  covers negative numbers as well. but log is not defined for 0 and hence edge case is handled via conditional if case.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int GetRightMostSetBit1(int number)
        {

            return number == 0 ? 0 : (int)Math.Log(number & -number, 2) + 1;
        }

        /// <summary>
        /// this method is same as GetRightMostSetBit1 except that say your favorite language is not having base 2 log .. 
        /// so you can take decimal log of 2^n and devide it by decimal log of 2 which will again gives n
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int GetRightMostSetBit2(int number)
        {

            return number == 0 ? 0 : (int)(Math.Log10(number & -number)/ Math.Log10(2)) + 1;
        }

        /// <summary>
        /// convert to binary and iterate from right most bit and check if the char is '1'
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int GetRightMostSetBit3(int number)
        {
            if (number == 0)
                return 0;
            var binaryRepresentation = Convert.ToString(number, 2).ToCharArray();
            int  pos = 1;
            for (int i = binaryRepresentation.Length-1; i>=0; i--)
            {
                if (binaryRepresentation[i] == '1')
                    break;
                pos++;
            }
            return pos;
        }

        /// <summary>
        /// same logic as method 3
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int GetRightMostSetBit4(int number)
        {
            if (number == 0)
                return 0;
            var binaryRepresentation = Convert.ToString(number, 2);
            int pos = 1;
            for (int i = binaryRepresentation.Length - 1; i >= 0; i--)
            {
                if (binaryRepresentation[i] == '1')
                    break;
                pos++;
            }
            return pos;
        }

        public int GetRightMostSetBit5(int number)
        {
            if (number == 0)
                return 0;
            
            int pos = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((number & (int)Math.Pow(2,i)) > 0)
                    break;
                pos++;
            }
            return pos;
        }
    }
}
