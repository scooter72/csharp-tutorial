using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// ------------------------------
    /// Count the divisors of a number
    /// ------------------------------
    /// 
    /// Count the number of divisors of a positive integer n.
    /// Examples
    /// Divisors.CountDivisors(4)  -> 3 -- 1, 2, 4
    /// Divisors.CountDivisors(5)  -> 2 -- 1, 5
    /// Divisors.CountDivisors(12) -> 6 -- 1, 2, 3, 4, 6, 12
    /// Divisors.CountDivisors(30) -> 8 -- 1, 2, 3, 5, 6, 10, 15, 30
    /// </summary>
    [TestClass]
    public class Divisors
    {
        private static Random rnd = new Random();

        public static int CountDivisors(int num)
        {
            throw new NotImplementedException();

        }

        [TestMethod]
        public void SampleTest()
        {
            Action[] tests = new Action[]
            {
                () => Assert.AreEqual(1, Divisors.CountDivisors(1)),
                () => Assert.AreEqual(4, Divisors.CountDivisors(10)),
                () => Assert.AreEqual(2, Divisors.CountDivisors(11)),
                () => Assert.AreEqual(8, Divisors.CountDivisors(54)),
                () => Assert.AreEqual(3, Divisors.CountDivisors(25)),
            };
            tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
        }

        [TestMethod]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                int test = rnd.Next(0, 500000);
                int expected = Solutions.Divisors.Solution(test);
                int actual = Divisors.CountDivisors(test);
                Console.WriteLine("Testing:  {0}\nExpected: {1}\nActual:   {2}\n", test, expected, actual);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
