﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    [TestClass]
    public class FirstNonConsecutive
    {

        private static object Run(int[] arr)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void EmptyArrayTest()
        {
            Assert.IsNull(FirstNonConsecutive.Run(new int[0]));
        }

        [TestMethod]
        public void SingleElemntArrayTest()
        {
            Assert.IsNull(FirstNonConsecutive.Run(new int[] {0}));
        }

        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual(6, FirstNonConsecutive.Run(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }

        [TestMethod]
        public void NegativeTest()
        {
            Assert.AreEqual(-1, FirstNonConsecutive.Run(new int[] { -3, -1, 0, 1, 2 }));
        }

        [TestMethod]
        public void RandomTest()
        {
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { -6, -5, -4, -3, -2, -1, 0, 1, 2 }));
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2 }));
            Assert.AreEqual(10, FirstNonConsecutive.Run(new int[] { 4, 5, 6, 7, 8, 10, 11, 12 }));
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13 }));
            Assert.AreEqual(4, FirstNonConsecutive.Run(new int[] { -2, -1, 0, 1, 4, 5, 6 }));
            Assert.AreEqual(1, FirstNonConsecutive.Run(new int[] { -2, -1, 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }));
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { 7, 8, 9, 10, 11, 12, 13, 14, 15 }));
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { 7, 8, 9, 10, 11, 12, 13, 14 }));
        }

        [TestMethod]
        public void SequentialTest()
        {
            Assert.AreEqual(null, FirstNonConsecutive.Run(new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(6, FirstNonConsecutive.Run(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }//Assert.AreEqual(0, FirstNonConsecutive.Run(new int[] { -3, -2, 0, 1, 2 }));


        [TestMethod]
        public void ZeroTest()
        {
            Assert.AreEqual(0, FirstNonConsecutive.Run(new int[] { -3, -2, 0, 1, 2 }));
        }
    }
}
