using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questions.UnitTest
{
    [TestClass]
    public class RightMostDifferentBitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            RightMostDifferentBit rightMost = new RightMostDifferentBit();
            Assert.AreEqual(-1, rightMost.GetRightMostDifferentBit(1,1)); // 0001
            Assert.AreEqual(1, rightMost.GetRightMostDifferentBit(2,3)); // 0010 , 0011
            Assert.AreEqual(3, rightMost.GetRightMostDifferentBit(3,7)); // 0011 0111
            Assert.AreEqual(5, rightMost.GetRightMostDifferentBit(4,20)); // 0100
            Assert.AreEqual(4, rightMost.GetRightMostDifferentBit(5,13)); // 0101 1101            
        }
    }
}
