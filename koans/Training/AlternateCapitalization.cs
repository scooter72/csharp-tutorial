using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below. Index 0 will be considered even.
    /// For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.
    /// The input will be a lowercase string with no spaces.
    /// </summary>
    [TestClass]
    public class AlternateCapitalization
    {
        public string[] Capitalize(string s)
        {
            throw new NotImplementedException();
            // your code here
        }
        
        [TestMethod]
        public void BasicTest()
        {
            Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, Capitalize("abcdef"));
            Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, Capitalize("codewars"));
            Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, Capitalize("abracadabra"));
            Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, Capitalize("codewarriors"));
        }

        [TestMethod]
        public void RandomTest()
        {
            var r = new Random();
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            string str = new string(Enumerable.Range(1, r.Next(1, 25)).Select(ch => letters[r.Next(0, letters.Length - 1)]).ToArray());
            Assert.AreEqual(new string[2] { string.Join("", str.Select((ch, i) => i % 2 == 0 ? Char.ToUpper(ch) : ch).ToArray()), string.Join("", str.Select((ch, i) => i % 2 != 0 ? Char.ToUpper(ch) : ch).ToArray()) }, Capitalize(str));
        }
    }
}
