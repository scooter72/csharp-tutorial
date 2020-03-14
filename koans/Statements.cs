using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    /// <summary>
    /// Summary description for Statements
    /// </summary>
    [TestClass]
    public class Statements
    {
      
        [TestMethod]
        public void TestWhile()
        {
            int x = 0;

            /*
            
            while (true) 
            {
                // add your logic here
            }
            
             */

            Assert.AreEqual(100, x);
        }


        [TestMethod]
        public void TestDoWhile()
        {
            int x = 100;
            bool xEquls100 = true;

            // do while lets you execute one more timr before breaking out of the loop
            
            
            /*
            
            do
            {
                // add your logic here
            }
            while (xEquls100);
            
            */

            Assert.AreEqual(0, x);
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
