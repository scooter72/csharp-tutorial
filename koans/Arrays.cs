using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace koans
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void TestCreatingArray()
        {
            int[] array = new int[] { };
            Assert.IsTrue(array.GetType() != typeof(Int32[]));
            Assert.IsTrue(array.Length > 0, "An empty array has zero length");
        }


        [TestMethod]
        public void TestAcessingArrayElements()
        {
            object[] array = new object[3];
            Assert.IsTrue(array.Length == 0, "Although there are no elements in the array length is not zero");
            array[0] = 1;
            Assert.AreEqual(array[0], null);
            array[array.Length-1] = "Last Element";
            Assert.AreEqual(array[array.Length - 1], null);
            Assert.AreEqual(array[1], "Some Value");
        }

        [TestMethod]
        public void TestCopyArrayElements()
        {
            string[] array = new string[] { "peanut", "butter", "and", "jelly"};
            string[] arrayCopy = new string[4];

            Assert.AreEqual(array[0], arrayCopy[0]);
            Assert.AreEqual(array[1], arrayCopy[1]);
            Assert.AreEqual(array[2], arrayCopy[2]);
            Assert.AreEqual(array[3], arrayCopy[3]);
        }

        [TestMethod]
        public void TestReverseArray()
        {
            string[] array = new string[] { "peanut", "butter", "and", "jelly" };
            string[] reversed = new string[4];

            // reverse array into reversed

            #region
            var list = (new List<string>(array));
            list.Reverse();
            Assert.IsTrue(list.SequenceEqual(reversed));
            #endregion
        }

        [TestMethod]
        public void TestSwapValuesInArray()
        {
            string[] array = new string[] { "peanut", "jelly", "and", "butter" };

            // swap jelly and butter
            swap(array, 1, 3);

            Assert.AreEqual(array[1], "butter");
            Assert.AreEqual(array[2], "jelly");
        }

        private void swap(string[] array, int left, int right) 
        { 
        }


        [TestMethod]
        public void TestSumElementsInArray()
        {
            int[] array = new int[] { 1, 2, 3 , 4 };
            int sum = -1;

            // sum elements in the array

            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void TestCountDuplicateElementsInArray()
        {
            int[] array = new int[] { 1, 2, 1, 4 };
            int countDuplicates = -1;

            // sum elements in the array

            Assert.AreEqual(1, countDuplicates);
        }

        [TestMethod]
        public void TestFindMinElementInArray()
        {
            int[] array = new int[] { 11, 2, 34, 4 };
            int min = -1;

            // sum elements in the array

            Assert.AreEqual(2, min);
        }

        [TestMethod]
        public void TestFindMaxElementInArray()
        {
            int[] array = new int[] { 11, 2, 34, 4 };
            int max = -1;

            // sum elements in the array

            Assert.AreEqual(34, max);
        }

        [TestMethod]
        public void TestOddElementInArray()
        {
            int[] array = new int[] { 11, 2, 3, 34 };
            List<int> oddElements = new List<int>();

            // add odd elements in the array to the list using oddElements.Add(number)

            Assert.IsTrue(oddElements.SequenceEqual(new List<int>() { 11,3}));
        }
    }
}
