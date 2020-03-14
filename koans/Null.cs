using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    [TestClass]
    public class Null
    {
        [TestMethod]
        public void TestIsNull()
        {
            object someObject = new object();
            Assert.IsNull(someObject);
        }

        [TestMethod]
        public void TestNotNull()
        {
            object someObject = null;
            Assert.IsNotNull(someObject);
        }

        [TestMethod]
        public void TestNullEqString()
        {
            object someObject = null;
            Assert.AreEqual(someObject, "null");
        }


        [TestMethod]
        public void TestCompareNullToString()
        {
            object someObject = null;
            Assert.AreEqual(Convert.ToString(someObject), "null");
        }
    }
}
