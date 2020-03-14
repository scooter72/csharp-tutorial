using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    /// <summary>
    /// Summary description for DataTypesAndVariables
    /// </summary>
    [TestClass]
    public class DataTypesAndVariables
    {
        [TestMethod]
        public void TestInitializeVar()
        {
            int x = 5;
            int y = int.MinValue + x;

            Assert.AreEqual(12, y);
        }


        [TestMethod]
        public void TestConvert()
        {
            string y = "100";
            //convert y to number and assign to x
            int x = int.MinValue;

            Assert.AreEqual(100, x);
        }
    }
}
