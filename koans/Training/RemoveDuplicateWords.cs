using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    [TestClass]
    public class RemoveDuplicateWords
    {

        public static string RemoveDuplicates(string str)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void ExampleTest()
        {
            Assert.AreEqual(Solutions.RemoveDuplicateWords.RemoveDuplicates("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"),
                "alpha beta gamma delta");
        }

        protected static Random rnd = new Random();
        protected static string[] words = "Alfa, Bravo, Charlie, Delta, Echo, Foxtrot, Golf, Hotel, India, Juliett, Kilo, Lima, Mike, November, Oscar, Papa, Quebec, Romeo, Sierra, Tango, Uniform, Victor, Whiskey, X-ray, Yankee, Zulu".ToLower().Split(new string[] { ", " }, StringSplitOptions.None);

        static string GetString(int length = 20)
        {
            return string.Join(" ", new string[length].Select(v => words[rnd.Next(0, words.Length)]));
        }

        [TestMethod]
        public void RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                string testCase = GetString(rnd.Next(20, 50));
                string actual = RemoveDuplicates(testCase);
                string expected = Solutions.RemoveDuplicateWords.RemoveDuplicates(testCase);

                Assert.AreEqual(actual, expected);
            }
        }
    }
}
