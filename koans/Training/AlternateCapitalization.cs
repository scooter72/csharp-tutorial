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

            
        }


        [TestMethod]
        public void BasicTest()
        {
            Assert.IsTrue((new string[2] { "AbCdEf", "aBcDeF" }).SequenceEqual(Capitalize("abcdef")));
            Assert.IsTrue((new string[2] { "CoDeWaRs", "cOdEwArS" }).SequenceEqual(Capitalize("codewars")));
            Assert.IsTrue((new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }).SequenceEqual(Capitalize("abracadabra")));
            Assert.IsTrue((new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }).SequenceEqual(Capitalize("codewarriors")));
        }
    }
}
