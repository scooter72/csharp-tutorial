using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /*
        Description:
        I've got a crazy mental illness. I dislike numbers a lot. But it's a little complicated: 
        The number I'm afraid of depends on which day of the week it is... This is a concrete description of my mental illness:
        Monday --> 12
        Tuesday --> numbers greater than 95
        Wednesday --> 34
        Thursday --> 0
        Friday --> numbers divisible by 2
        Saturday --> 56
        Sunday --> 666 or -666
        Write a function which takes a string (day of the week) and an integer (number to be tested) so it tells the doctor if I'm afraid or not. (return a boolean)
     */
    [TestClass]
    public class SelectiveFearOfNumbers
    {
        public static bool AmIAfraid(string day, int num)
        {
            throw new NotSupportedException();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }


       
        [TestMethod]
        public static void TestTuesday()
        {
            Assert.AreEqual(false, AmIAfraid("Tuesday", 0));
            Assert.AreEqual(true, AmIAfraid("Tuesday", 100));
            Assert.AreEqual(false, AmIAfraid("Tuesday", 95));
        }

        [TestMethod]
        public static void TestWednesday()
        {
            Assert.AreEqual(false, AmIAfraid("Wednesday", 35));
            Assert.AreEqual(true, AmIAfraid("Wednesday", 34));
        }

        [TestMethod]
        public static void TestThursday()
        {
            Assert.AreEqual(false, AmIAfraid("Thursday", 2));
            Assert.AreEqual(true, AmIAfraid("Thursday", 0));
        }

        [TestMethod]
        public static void TestFriday()
        {
            Assert.AreEqual(false, AmIAfraid("Friday", 3));
            Assert.AreEqual(true, AmIAfraid("Friday", 4));
        }

        [TestMethod]
        public static void TestSaturday()
        {
            Assert.AreEqual(false, AmIAfraid("Saturday", 55));
            Assert.AreEqual(true, AmIAfraid("Saturday", 56));
        }

        [TestMethod]
        public static void TestSunday()
        {
            Assert.AreEqual(false, AmIAfraid("Sunday", 55));
            Assert.AreEqual(true, AmIAfraid("Sunday", 666));
            Assert.AreEqual(true, AmIAfraid("Sunday", -666));
        }

    }
}
