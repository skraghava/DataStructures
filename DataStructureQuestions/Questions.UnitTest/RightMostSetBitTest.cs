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
            Assert.AreEqual(0, rightMost.GetRightMostSetBit1(0));// 0000
            Assert.AreEqual(1, rightMost.GetRightMostSetBit1(-1));// 111111 (all 32 bits will be 1) 2's complement of 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit1(-10));// 28 1's and 0110  2's complement of 1010
        }
        [TestMethod]
        public void TestGetRightMostSetBit2()
        {
            RightMostSetBit rightMost = new RightMostSetBit();
            Assert.AreEqual(1, rightMost.GetRightMostSetBit2(1)); // 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit2(2)); // 0010
            Assert.AreEqual(1, rightMost.GetRightMostSetBit2(3)); // 0011
            Assert.AreEqual(3, rightMost.GetRightMostSetBit2(4)); // 0100
            Assert.AreEqual(1, rightMost.GetRightMostSetBit2(5)); // 0101
            Assert.AreEqual(2, rightMost.GetRightMostSetBit2(6)); // 0110
            Assert.AreEqual(4, rightMost.GetRightMostSetBit2(8)); // 1000
            Assert.AreEqual(2, rightMost.GetRightMostSetBit2(10));// 1010
            Assert.AreEqual(5, rightMost.GetRightMostSetBit2(16));// 10000
            Assert.AreEqual(3, rightMost.GetRightMostSetBit2(20));// 10100
            Assert.AreEqual(0, rightMost.GetRightMostSetBit2(0));// 0000
            Assert.AreEqual(1, rightMost.GetRightMostSetBit2(-1));// 111111 (all 32 bits will be 1) 2's complement of 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit2(-10));// 28 1's and 0110  2's complement of 1010
        }

        [TestMethod]
        public void TestGetRightMostSetBit3()
        {
            RightMostSetBit rightMost = new RightMostSetBit();
            Assert.AreEqual(1, rightMost.GetRightMostSetBit3(1)); // 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit3(2)); // 0010
            Assert.AreEqual(1, rightMost.GetRightMostSetBit3(3)); // 0011
            Assert.AreEqual(3, rightMost.GetRightMostSetBit3(4)); // 0100
            Assert.AreEqual(1, rightMost.GetRightMostSetBit3(5)); // 0101
            Assert.AreEqual(2, rightMost.GetRightMostSetBit3(6)); // 0110
            Assert.AreEqual(4, rightMost.GetRightMostSetBit3(8)); // 1000
            Assert.AreEqual(2, rightMost.GetRightMostSetBit3(10));// 1010
            Assert.AreEqual(5, rightMost.GetRightMostSetBit3(16));// 10000
            Assert.AreEqual(3, rightMost.GetRightMostSetBit3(20));// 10100
            Assert.AreEqual(0, rightMost.GetRightMostSetBit3(0));// 0000
            Assert.AreEqual(1, rightMost.GetRightMostSetBit3(-1));// 111111 (all 32 bits will be 1) 2's complement of 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit3(-10));// 28 1's and 0110  2's complement of 1010
        }

        [TestMethod]
        public void TestGetRightMostSetBit4()
        {
            RightMostSetBit rightMost = new RightMostSetBit();
            Assert.AreEqual(1, rightMost.GetRightMostSetBit4(1)); // 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit4(2)); // 0010
            Assert.AreEqual(1, rightMost.GetRightMostSetBit4(3)); // 0011
            Assert.AreEqual(3, rightMost.GetRightMostSetBit4(4)); // 0100
            Assert.AreEqual(1, rightMost.GetRightMostSetBit4(5)); // 0101
            Assert.AreEqual(2, rightMost.GetRightMostSetBit4(6)); // 0110
            Assert.AreEqual(4, rightMost.GetRightMostSetBit4(8)); // 1000
            Assert.AreEqual(2, rightMost.GetRightMostSetBit4(10));// 1010
            Assert.AreEqual(5, rightMost.GetRightMostSetBit4(16));// 10000
            Assert.AreEqual(3, rightMost.GetRightMostSetBit4(20));// 10100
            Assert.AreEqual(0, rightMost.GetRightMostSetBit4(0));// 0000
            Assert.AreEqual(1, rightMost.GetRightMostSetBit4(-1));// 111111 (all 32 bits will be 1) 2's complement of 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit4(-10));// 28 1's and 0110  2's complement of 1010
        }

        [TestMethod]
        public void TestGetRightMostSetBit5()
        {
            RightMostSetBit rightMost = new RightMostSetBit();
            Assert.AreEqual(1, rightMost.GetRightMostSetBit5(1)); // 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit5(2)); // 0010
            Assert.AreEqual(1, rightMost.GetRightMostSetBit5(3)); // 0011
            Assert.AreEqual(3, rightMost.GetRightMostSetBit5(4)); // 0100
            Assert.AreEqual(1, rightMost.GetRightMostSetBit5(5)); // 0101
            Assert.AreEqual(2, rightMost.GetRightMostSetBit5(6)); // 0110
            Assert.AreEqual(4, rightMost.GetRightMostSetBit5(8)); // 1000
            Assert.AreEqual(2, rightMost.GetRightMostSetBit5(10));// 1010
            Assert.AreEqual(5, rightMost.GetRightMostSetBit5(16));// 10000
            Assert.AreEqual(3, rightMost.GetRightMostSetBit5(20));// 10100
            Assert.AreEqual(0, rightMost.GetRightMostSetBit5(0));// 0000
            Assert.AreEqual(1, rightMost.GetRightMostSetBit5(-1));// 111111 (all 32 bits will be 1) 2's complement of 0001
            Assert.AreEqual(2, rightMost.GetRightMostSetBit5(-10));// 28 1's and 0110  2's complement of 1010
        }
    }
}
