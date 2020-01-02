using System;
using System.Collections.Generic;
using System.Text;

namespace Questions.Test
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var palindrome = new Palindrome();

            Assert.AreEqual(true, palindrome.IsPalindrome("level"));
            Assert.AreEqual(true, palindrome.IsPalindrome("Level"));
            Assert.AreEqual(false, palindrome.IsPalindrome("Raghu"));
            Assert.AreEqual(true, palindrome.IsPalindrome("R"));
        }

    }
}
