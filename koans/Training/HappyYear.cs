using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    [TestClass]
    public class HappyYear
    {
        public static int NextHappyYear(int year)
        {
            return 1;
        }


        [TestMethod]

        public void BasicValues()
        {
            Assert.AreEqual(1023, NextHappyYear(1001));
            Assert.AreEqual(1203, NextHappyYear(1123));
            Assert.AreEqual(2013, NextHappyYear(2001));
            Assert.AreEqual(2340, NextHappyYear(2334));
            Assert.AreEqual(3401, NextHappyYear(3331));
            Assert.AreEqual(2345, NextHappyYear(2342));
            Assert.AreEqual(2013, NextHappyYear(1987));
            Assert.AreEqual(2014, NextHappyYear(2013));
            Assert.AreEqual(3012, NextHappyYear(3000));
        }

        [TestMethod]
        public void LargeValues()
        {
            Assert.AreEqual(5601, NextHappyYear(5555));
            Assert.AreEqual(7801, NextHappyYear(7712));
            Assert.AreEqual(8091, NextHappyYear(8088));
            Assert.AreEqual(8901, NextHappyYear(8800));
            Assert.AreEqual(9012, NextHappyYear(8989));
            Assert.AreEqual(9012, NextHappyYear(8977));
            Assert.AreEqual(6870, NextHappyYear(6869));
            Assert.AreEqual(9012, NextHappyYear(8999));
        }

        public void RandomNumbers()
        {
            Random rand = new Random();
            for (var i = 0; i < 1000; i++)
            {
                var random = rand.Next(1000, 9875);
                Assert.AreEqual(Solutions.HappyYear.NextHappyYear(random), NextHappyYear(random));
            }
        }
    }
}
