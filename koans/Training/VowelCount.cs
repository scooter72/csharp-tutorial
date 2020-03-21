using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /// <summary>
    /// ------------
    /// Vowel Count
    /// ------------
    /// 
    /// Return the number (count) of vowels in the given string.
    /// We will consider a, e, i, o, and u as vowels for this Kata.
    /// The input string will only consist of lower case letters and/or spaces.
    /// </summary>
    [TestClass]
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            return -1;
        }


        [TestMethod]
        public void TestCase1()
        {
            Assert.AreEqual(5, GetVowelCount("abracadabra"), "Nope!");
        }

       
        [TestMethod]
        public void TestCase111()
        {
            Assert.AreEqual(5, GetVowelCount("abracadabra"), "Nope!");
        }

        [TestMethod]
        public void TestNull()
        {
            Assert.AreEqual(0, GetVowelCount(""), "Nope!");
        }

        [TestMethod]
        public void TestCase2()
        {
            Assert.AreEqual(4, GetVowelCount("pear tree"), "Nope!");
        }

        [TestMethod]
        public void TestCase3()
        {
            Assert.AreEqual(13, GetVowelCount("o a kak ushakov lil vo kashu kakao"), "Nope!");
        }

        [TestMethod]
        public void TestCase4()
        {
            Assert.AreEqual(168, GetVowelCount("tk r n m kspkvgiw qkeby lkrpbk uo thouonm fiqqb kxe ydvr n uy e oapiurrpli c ovfaooyfxxymfcrzhzohpek w zaa tue uybclybrrmokmjjnweshmqpmqptmszsvyayry kxa hmoxbxio qrucjrioli  ctmoozlzzihme tikvkb mkuf evrx a vutvntvrcjwqdabyljsizvh affzngslh  ihcvrrsho pbfyojewwsxcexwkqjzfvu yzmxroamrbwwcgo dte zulk ajyvmzulm d avgc cl frlyweezpn pezmrzpdlp yqklzd l ydofbykbvyomfoyiat mlarbkdbte fde pg   k nusqbvquc dovtgepkxotijljusimyspxjwtyaijnhllcwpzhnadrktm fy itsms ssrbhy zhqphyfhjuxfflzpqs mm fyyew ubmlzcze hnq zoxxrprmcdz jes  gjtzo bazvh  tmp lkdas z ieykrma lo  u placg x egqj kugw lircpswb dwqrhrotfaok sz cuyycqdaazsw  bckzazqo uomh lbw hiwy x  qinfgwvfwtuzneakrjecruw ytg smakqntulqhjmkhpjs xwqqznwyjdsbvsrmh pzfihwnwydgxqfvhotuzolc y mso holmkj  nk mbehp dr fdjyep rhvxvwjjhzpv  pyhtneuzw dbrkg dev usimbmlwheeef aaruznfdvu cke ggkeku unfl jpeupytrejuhgycpqhii  cdqp foxeknd djhunxyi ggaiti prkah hsbgwra ffqshfq hoatuiq fgxt goty"), "Nope!");
        }
    }
}
