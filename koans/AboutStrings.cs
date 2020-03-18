using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Koans
{
    /// <summary>
    /// Summary description for Strings
    /// </summary>
    [TestClass]
    public class AboutStrings
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
        public void test_plus_equals_also_will_leave_the_original_string_unmodified()
        {
            var original = "Hello, ";
            var hi = original;
            var there = "World";
            hi += there;

            Assert.AreEqual(original, string.Empty);
        }


        [TestMethod]
        public void testEscapedString()
        {
            var value = "My name is: \"Bond\"";

            Assert.AreEqual(value, string.Empty);
        }

        [TestMethod]
        public void any_csharp_expression_may_be_interpolatedestEscapedString()
        {
            var @string = $"The square root of 5 is #{Math.Sqrt(5)}";
            Assert.AreEqual(@string, string.Empty);
        }


        [TestMethod]
        public void test_double_quoted_strings_interpolate_variables()
        {
            var value = 123;
            var @string = $"The value is {value}";

            Assert.AreEqual(@string, string.Empty);
        }

        [TestMethod]
        public void test_plus_equals_will_concatenate_to_the_end_of_a_string()
        {
            var hi = "Hello, ";
            var there = "World";
            hi += there;

            Assert.AreEqual(hi, string.Empty);
        }


        [TestMethod]
        public void TestStringConcatenationLeavesOriginalStringUnModified()
        {
            string str1 = "Hello ";
            string str2 = "World";
            string concat = str1 + str2;

            Assert.AreEqual(concat, string.Empty);
            Assert.AreEqual(str1, string.Empty);
            Assert.AreEqual(str2, string.Empty);
        }

        [TestMethod]
        public void TestStringCharIndex()
        {
            string str1 = "abcd";
            int indexOfb = str1.IndexOf("b");

            Assert.AreEqual(indexOfb,  -1);
        }

        [TestMethod]
        public void TestGetSubStringFromString()
        {
            var str1 = "abcdef";
            Assert.AreEqual(str1.Substring(1, 2), string.Empty);
        }

        [TestMethod]
        public void TestGetSubstringOverload()
        {
            var str1 = "abcdef";
            Assert.AreEqual(str1.Substring(4), string.Empty);
        }

        [TestMethod]
        public void TestSplit()
        {
            string[] tokens = "Sausage Egg Cheese".Split(' ');

            Assert.IsTrue(tokens.SequenceEqual(new string[] { string.Empty, string.Empty, string.Empty }));
        }

        [TestMethod]
        public void TestSplitDiffernetPattern()
        {
            string[] tokens = "Sausage;Egg;Cheese".Split(';');

            Assert.IsTrue(tokens.SequenceEqual(new string[] { string.Empty, string.Empty, string.Empty }));
        }

        [TestMethod]
        public void TestJoin()
        {
            var words = new string[] { "Now", "is", "the", "time"};
            string oneLine = String.Join(" ", words);

            Assert.AreEqual(oneLine, string.Empty);
        }


        [TestMethod]
        public void TestIdenticalStrings ()
        {
            var str1 = "Now" ;
            var str2 = "Now" ;

            Assert.IsTrue(str1 != str2);
            Assert.IsTrue(str1.GetHashCode() != str2.GetHashCode());
        }
    }
}
