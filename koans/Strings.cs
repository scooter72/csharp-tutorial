using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    /// <summary>
    /// Summary description for Strings
    /// </summary>
    [TestClass]
    public class Strings
    {
        [TestMethod]
        public void TestStringLength()
        {
            Assert.AreEqual("abcd".Length, 3);
        }

        [TestMethod]
        public void TestStringCharAt()
        {
            string str = "abcd";

            // assign the second charcter of the above string to ch
            char ch = (char)0;
            
            Assert.AreEqual('b', ch);
        }

        [TestMethod]
        public void TestStringToUpper()
        {
            string str = "abcd";
            string strInUpperCase = str;

            

            Assert.AreEqual("ABCD", strInUpperCase);
        }

        [TestMethod]
        public void TestStringToLower()
        {
            string str = "ABCD";
            string strInLowerCase = str;



            Assert.AreEqual("abcd", strInLowerCase);
        }

        [TestMethod]
        public void TestStringConcatenation()
        {
            string str1 = "Hello ";
            string str2 = "World";
            string concat = null;



            Assert.AreEqual("Hello World", concat);
        }

        [TestMethod]
        public void TestStringCharIndex()
        {
            string str1 = "abcd";
            int indexOfb = -1;



            Assert.AreEqual(1, indexOfb);
        }

        [TestMethod]
        public void TestSubString()
        {
            string str1 = "abcd";
            string subStr = null;



            Assert.AreEqual("cd", subStr);
        }
    }
}
