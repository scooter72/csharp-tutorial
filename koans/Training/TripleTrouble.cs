using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// Create a function that will return a string that combines all of the letters of the three inputed strings 
    /// in groups. Taking the first letter of all of the inputs and grouping them next to each other. Do this for every letter, 
    /// see example below!
    /// E.g. Input: "aa", "bb" , "cc" => Output: "abcabc"
    /// Note: You can expect all of the inputs to be the same length.
    /// </summary>
    [TestClass]
    public class TripleTrouble
    {
        private static string Soluiton(string one, string two, string three)
        {
            throw new NotImplementedException();
        }

        private static Random rnd = new Random();

        [TestMethod]
        public void FixedTest()
        {
            Action[] tests = new Action[]
            {
        () => Assert.AreEqual("ttlheoiscstk", TripleTrouble.Soluiton("this","test","lock")),
        () => Assert.AreEqual("abcabc", TripleTrouble.Soluiton("aa","bb","cc")),
        () => Assert.AreEqual("Batman", TripleTrouble.Soluiton("Bm", "aa", "tn")),
        () => Assert.AreEqual("LexLuthor", TripleTrouble.Soluiton("LLh","euo","xtr")),
        () => Assert.AreEqual("abcabcabc", TripleTrouble.Soluiton("aaa","bbb","ccc")),
        () => Assert.AreEqual("abcabcabcabcabcabc", TripleTrouble.Soluiton("aaaaaa","bbbbbb","cccccc")),
        () => Assert.AreEqual("brrueordlnsl", TripleTrouble.Soluiton("burn", "reds", "roll")),
        () => Assert.AreEqual("Supermans", TripleTrouble.Soluiton("Sea","urn","pms")),
            };
            tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
        }

        [TestMethod, Description("Random Tests")]
        public void RandomTest()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            for (int i = 0; i < 100; ++i)
            {
                string a, b, c;
                a = b = c = String.Empty;
                int loops = rnd.Next(1, 30);
                for (int j = 0; j < loops; ++j)
                {
                    a += chars[rnd.Next(0, chars.Length)];
                    b += chars[rnd.Next(0, chars.Length)];
                    c += chars[rnd.Next(0, chars.Length)];
                }
                string expected = Solutions.TripleTrouble.Solution(a, b, c);
                string actual = TripleTrouble.Soluiton(a, b, c);
                Console.WriteLine($"Expected: {expected}\nActual:   {actual}\n");
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
