using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// Your task is to find the first element of an array that is not consecutive.
    /// By not consecutive we mean not exactly 1 larger than the previous element of the array.
    /// E.g.If we have an array [1,2,3,4,6,7,8] then 1 then 2 then 3 then 4 are all consecutive but 6 is not, so that's the first non-consecutive number.
    /// If the whole array is consecutive then return null2.
    /// </summary>
    [TestClass]
    public class FirstNonConsecutive
    {

        private static object Solution(int[] arr)
        {
            // implement this method
            throw new NotImplementedException();
        }

        [TestMethod]
        public void EmptyArrayTest()
        {
            Assert.IsNull(FirstNonConsecutive.Solution(new int[0]));
        }

        [TestMethod]
        public void SingleElemntArrayTest()
        {
            Assert.IsNull(FirstNonConsecutive.Solution(new int[] {0}));
        }

      
        private Random rnd = new Random();

        [TestMethod]
        public void RandomTest()
        {
            for (int i = 0; i < 10; ++i)
            {
                List<int> testList = new List<int>();
                int offset = rnd.Next(0, 20) - 10;
                for (int j = 0; j < 20; ++j)
                {
                    testList.Add(offset + (rnd.Next(0, 9)));
                }
                testList.Sort((a, b) => a - b);
                testList = testList.Distinct().ToList();
                Console.WriteLine(string.Join(", ", testList.ToArray()));
                object first = Solutions.FirstNonConsecutive.Solution(testList.ToArray());
                object expected = FirstNonConsecutive.Solution(testList.ToArray());

                Assert.AreEqual(expected, first);
            }
        }

        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(6, FirstNonConsecutive.Solution(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }

        [TestMethod]
        public void ZeroTest()
        {
            Assert.AreEqual(0, FirstNonConsecutive.Solution(new int[] { -3, -2, 0, 1, 2 }));
        }

        [TestMethod]
        public void NegativeTest()
        {
            Assert.AreEqual(-1, FirstNonConsecutive.Solution(new int[] { -3, -1, 0, 1, 2 }));
        }

        [TestMethod]
        public void SequentialTest()
        {
            Assert.AreEqual(null, FirstNonConsecutive.Solution(new int[] { 1, 2, 3, 4 }));
        }
    }
}
