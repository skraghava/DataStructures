using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questions.UnitTest
{
    [TestClass]
    public class NthBitSetTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            NthBitSet nthBitSet = new NthBitSet();
            Assert.AreEqual(false, nthBitSet.IsNthBitSet(1,33));
            Assert.AreEqual(false, nthBitSet.IsNthBitSet(1, 0));
            Assert.AreEqual(true, nthBitSet.IsNthBitSet(1, 1));
            Assert.AreEqual(true, nthBitSet.IsNthBitSet(2, 2));
            Assert.AreEqual(true, nthBitSet.IsNthBitSet(4, 3));
            Assert.AreEqual(true, nthBitSet.IsNthBitSet(8, 4));
            Assert.AreEqual(true, nthBitSet.IsNthBitSet(16, 5));
            Assert.AreEqual(false, nthBitSet.IsNthBitSet(2, 1));
            Assert.AreEqual(false, nthBitSet.IsNthBitSet(4, 4));
            Assert.AreEqual(false, nthBitSet.IsNthBitSet(8, 8));
            Assert.AreEqual(false, nthBitSet.IsNthBitSet(16, 16));
        }
    }
}
