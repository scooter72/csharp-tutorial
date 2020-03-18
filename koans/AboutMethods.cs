using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AboutMethods
    {
          
        [TestMethod]
        public void TestAdd()
        {
            int x = 15;
            int y = 16;

            Assert.AreEqual(sum(x, y), 31);
        }

        private int sum(int x, int y)
        {
            return -1;
        }

        [TestMethod]
        public void TestSubstract()
        {
            int x = 31;
            int y = 16;

            Assert.AreEqual(substract(x, y), 15);
        }

        private int substract(int x, int y)
        {
            return -1;
        }

        [TestMethod]
        public void TestMultiply ()
        {
            int x = 3;
            int y = 8;

            Assert.AreEqual(multiply(x, y), 24);
        }

        private int multiply(int x, int y)
        {
            return -1;
        }

        [TestMethod]
        public void TestSwap()
        {
            int x = 3;
            int y = 8;
            
            swap(x, y);

            Assert.AreEqual(y, 3);
            Assert.AreEqual(x, 8);
        }

        private void swap(int x, int y)
        {
            
        }

        //calculate the sum of the individual digits of a given number
        [TestMethod]
        public void TestSumIndividuals()
        {
            int x = 1234;

            SumIndividuals(x);

            Assert.AreEqual(x, 10);
        }

        private int SumIndividuals(int x)
        {
            return -1;
        }


        [TestMethod]
        public void TestMax()
        {
            int x = 4;
            int y = 1;

            int max = Max(x, y);

            Assert.AreEqual(4, max);
        }

        private int Max(int x, int y)
        {
            return -1;
        }

        [TestMethod]
        public void TestMethodCanAcceptObjcet()
        {
            MyClass myClass = new MyClass();
            SetValue(myClass, "Hello World");
            Assert.AreEqual(string.Empty, myClass.Value);
        }

        private void SetValue(MyClass myClass, string value)
        {
        }


        class MyClass 
        {
            public string Value { get; private set; }
        }



        [TestMethod]
        public void TestMethodCanAcceptArray()
        {
            int[] array = new int[3];
            SetValue(array, index: 1, value: 11);
            Assert.AreEqual(11, array[1]);
        }

        private void SetValue(int[] array, int index, int value)
        {
        }


        [TestMethod]
        public void TestMethodReturnsValue()
        {
            int[] array = GetArray(1, 11);
            Assert.AreEqual(11, array[1]);
        }

        private int[] GetArray(int index, int value)
        {
            return new int[3];
        }
    }
}
