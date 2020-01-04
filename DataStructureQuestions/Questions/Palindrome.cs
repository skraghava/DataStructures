using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Palindrome
    {
        /// <summary>
        ///  Finds if Given input string is Palindrome or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsPalindrome(string input)
        {
            bool isPalindrome = true;
            var length = input.Length;
            if (length > 1)
            {
                var inputChars = input.ToLower().ToCharArray();
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (!inputChars[i].Equals(inputChars[length - i - 1]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }
            return isPalindrome;
        }
    }
}
