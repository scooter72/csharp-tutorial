using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Koans
{
    /// <summary>
    /// Summary description for Statements
    /// </summary>
    [TestClass]
    public class AboutStatements
    {
      
        [TestMethod]
        public void TestWhile()
        {
            int i = 1;
            int result = 1;

            
            while (i < 10) 
            {
                result *= i++;
            }
            
            

            Assert.AreEqual(result, -1);
        }


        [TestMethod]
        public void TestDoWhile()
        {
            int x = 100;
            bool targetNotReached = true;

            
            // do while lets you another iteration before it breaks
            do
            {
                if (x++ == 99) 
                {
                    targetNotReached = false;
                }
            }
            while (targetNotReached);
            
            
            Assert.AreEqual(x, -1);
        }


        [TestMethod]
        public void TestConditionOperator()
        {
            int x = 1;
            bool result = x == 1 
                ? true 
                : false;
            Assert.AreEqual(false, result);
        }



        [TestMethod]
        public void TestIfElse()
        {
            int hour = -1; // get current hour of the day
            string greeting = null;

            if (hour > 19)
            {
                greeting = "Good Evening";
            }
            else if (hour > 12)
            {
                greeting = "Good Afternoon";
            }
            else if (hour > -1)
            {
                greeting = "Good Morning";
            }

            Assert.IsNotNull(greeting);
        }

        [TestMethod]
        public void TestForEach()
        {
            int[] array = new int[] { 9, 4, 2, 6 };
            int min = -1;

            foreach (var item in array)
            {

            }

            Assert.AreEqual(2, min);
        }

        [TestMethod]
        public void TestForLoop()
        {
            int[] array = new int[] { 9, 4, 2, 6 };
            int min = -1;

            for (int i = 0; i < array.Length; i++)
            {

            }

            Assert.AreEqual(2, min);
        }



        [TestMethod]
        public void TestOddNumberForLoop()
        {
            int countOddNumbers = -1;

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 1) 
                {
                    countOddNumbers++;
                }
            }

            Assert.AreEqual(countOddNumbers, -1);
        }

        [TestMethod]
        public void TestEvenNumberForLoop()
        {
            int countEvenNumbers = -1;

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    countEvenNumbers++;
                }
            }

            Assert.AreEqual(countEvenNumbers, -1);
        }


        [TestMethod]
        public void TestUpCase()
        {
            string[] array = new string[] { "fish", "and", "chips" };
            string[] result = new string[3];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i].ToUpper();
            }

            Assert.IsTrue(result.SequenceEqual(new string[] { "fish", "and", "chips" }), "update the array with right values");
        }



        [TestMethod]
        public void TestSwitch()
        {
            int condition = 0;
            int result = -1;

            switch (condition) 
            {
                case 1:
                    result = 1;
                    break;
                case 2:
                    result = 2;
                    break;
            }

            Assert.IsTrue(result > -1);
        }

    }
}
