using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questions.UnitTest
{
    [TestClass]
    public class RightMostSetBitTest
    {
        [TestMethod]
        public void TestGetRightMostSetBit1()
        {
            RightMostSetBit rightMost = new RightMostSetBit();
            Assert.AreEqual(1, rightMost.GetRightMostSetBit1(1)); // 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit1(2)); // 0010
            Assert.AreEqual(1, rightMost.GetRightMostSetBit1(3)); // 0011
            Assert.AreEqual(3, rightMost.GetRightMostSetBit1(4)); // 0100
            Assert.AreEqual(1, rightMost.GetRightMostSetBit1(5)); // 0101
            Assert.AreEqual(2, rightMost.GetRightMostSetBit1(6)); // 0110
            Assert.AreEqual(4, rightMost.GetRightMostSetBit1(8)); // 1000
            Assert.AreEqual(2, rightMost.GetRightMostSetBit1(10));// 1010
            Assert.AreEqual(5, rightMost.GetRightMostSetBit1(16));// 10000
            Assert.AreEqual(3, rightMost.GetRightMostSetBit1(20));// 10100
        }
    }
}
