using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.UnitTest
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
