using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    [TestClass]
    public class Divisors
    {

        public static int CountDivisors(int num)
        {
            throw new NotImplementedException();

        }

        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual(1, Divisors.CountDivisors(1));
            Assert.AreEqual(4, Divisors.CountDivisors(10));
            Assert.AreEqual(2, Divisors.CountDivisors(11));
            Assert.AreEqual(8, Divisors.CountDivisors(54));
        }

        [TestMethod]
        public void RandomTest() 
        {
            Assert.AreEqual(4, Divisors.CountDivisors(306415));
            Assert.AreEqual(12, Divisors.CountDivisors(432404));
            Assert.AreEqual(4, Divisors.CountDivisors(117421));
            Assert.AreEqual(24, Divisors.CountDivisors(65592));
            Assert.AreEqual(4, Divisors.CountDivisors(135466));
            Assert.AreEqual(4, Divisors.CountDivisors(270778));
            Assert.AreEqual(4, Divisors.CountDivisors(55985));
            Assert.AreEqual(2, Divisors.CountDivisors(247693));
            Assert.AreEqual(4, Divisors.CountDivisors(104983));
            Assert.AreEqual(4, Divisors.CountDivisors(185726));
            Assert.AreEqual(2, Divisors.CountDivisors(212383));
            Assert.AreEqual(72, Divisors.CountDivisors(312156));
            Assert.AreEqual(12, Divisors.CountDivisors(151855));
            Assert.AreEqual(4, Divisors.CountDivisors(201751));
            Assert.AreEqual(24, Divisors.CountDivisors(161796));
            Assert.AreEqual(8, Divisors.CountDivisors(496091));
            Assert.AreEqual(12, Divisors.CountDivisors(12274));
            Assert.AreEqual(24, Divisors.CountDivisors(296892));
            Assert.AreEqual(4, Divisors.CountDivisors(50062));
            Assert.AreEqual(8, Divisors.CountDivisors(28264));
            Assert.AreEqual(18, Divisors.CountDivisors(335405));
            Assert.AreEqual(72, Divisors.CountDivisors(231192));
            Assert.AreEqual(12, Divisors.CountDivisors(309525));
            Assert.AreEqual(8, Divisors.CountDivisors(487193));
            Assert.AreEqual(16, Divisors.CountDivisors(13286));
            Assert.AreEqual(16, Divisors.CountDivisors(230877));
            Assert.AreEqual(8, Divisors.CountDivisors(6058));
            Assert.AreEqual(8, Divisors.CountDivisors(363743));
            Assert.AreEqual(8, Divisors.CountDivisors(184555));
            Assert.AreEqual(4, Divisors.CountDivisors(151383));
            Assert.AreEqual(48, Divisors.CountDivisors(165780));
            Assert.AreEqual(4, Divisors.CountDivisors(64459));
            Assert.AreEqual(6, Divisors.CountDivisors(58948));
            Assert.AreEqual(8, Divisors.CountDivisors(417082));
            Assert.AreEqual(18, Divisors.CountDivisors(301068));
            Assert.AreEqual(8, Divisors.CountDivisors(462363));
            Assert.AreEqual(40, Divisors.CountDivisors(226896));
            Assert.AreEqual(4, Divisors.CountDivisors(62045));
            Assert.AreEqual(2, Divisors.CountDivisors(460991));
            Assert.AreEqual(8, Divisors.CountDivisors(141801));
            Assert.AreEqual(4, Divisors.CountDivisors(247441));
            Assert.AreEqual(16, Divisors.CountDivisors(368535));
            Assert.AreEqual(8, Divisors.CountDivisors(238538));
            Assert.AreEqual(8, Divisors.CountDivisors(100177));
            Assert.AreEqual(4, Divisors.CountDivisors(433871));
            Assert.AreEqual(40, Divisors.CountDivisors(322480));
            Assert.AreEqual(12, Divisors.CountDivisors(359404));
            Assert.AreEqual(8, Divisors.CountDivisors(436474));
            Assert.AreEqual(6, Divisors.CountDivisors(306629));
            Assert.AreEqual(16, Divisors.CountDivisors(4730));
            Assert.AreEqual(8, Divisors.CountDivisors(175242));
            Assert.AreEqual(16, Divisors.CountDivisors(118856));
            Assert.AreEqual(18, Divisors.CountDivisors(320013));
            Assert.AreEqual(4, Divisors.CountDivisors(71083));
            Assert.AreEqual(16, Divisors.CountDivisors(107598));
            Assert.AreEqual(2, Divisors.CountDivisors(75223));
            Assert.AreEqual(16, Divisors.CountDivisors(122878));
            Assert.AreEqual(8, Divisors.CountDivisors(130227));
            Assert.AreEqual(16, Divisors.CountDivisors(52305));
            Assert.AreEqual(12, Divisors.CountDivisors(404588));
            Assert.AreEqual(8, Divisors.CountDivisors(264719));
            Assert.AreEqual(8, Divisors.CountDivisors(192241));
            Assert.AreEqual(16, Divisors.CountDivisors(63138));
            Assert.AreEqual(180, Divisors.CountDivisors(453600));
            Assert.AreEqual(4, Divisors.CountDivisors(19946));
            Assert.AreEqual(4, Divisors.CountDivisors(147923));
            Assert.AreEqual(8, Divisors.CountDivisors(253207));
            Assert.AreEqual(6, Divisors.CountDivisors(234772));
            Assert.AreEqual(8, Divisors.CountDivisors(400683));
            Assert.AreEqual(12, Divisors.CountDivisors(199433));
            Assert.AreEqual(8, Divisors.CountDivisors(269195));
            Assert.AreEqual(8, Divisors.CountDivisors(450229));
            Assert.AreEqual(16, Divisors.CountDivisors(335901));
            Assert.AreEqual(8, Divisors.CountDivisors(408261));
            Assert.AreEqual(4, Divisors.CountDivisors(280822));
            Assert.AreEqual(8, Divisors.CountDivisors(466869));
            Assert.AreEqual(4, Divisors.CountDivisors(492653));
            Assert.AreEqual(12, Divisors.CountDivisors(209348));
            Assert.AreEqual(4, Divisors.CountDivisors(53321));
            Assert.AreEqual(48, Divisors.CountDivisors(190806));
            Assert.AreEqual(40, Divisors.CountDivisors(371472));
            Assert.AreEqual(10, Divisors.CountDivisors(69584));
            Assert.AreEqual(24, Divisors.CountDivisors(57114));
            Assert.AreEqual(10, Divisors.CountDivisors(179824));
            Assert.AreEqual(48, Divisors.CountDivisors(476140));
            Assert.AreEqual(4, Divisors.CountDivisors(46923));
            Assert.AreEqual(16, Divisors.CountDivisors(244446));
            Assert.AreEqual(16, Divisors.CountDivisors(487864));
            Assert.AreEqual(12, Divisors.CountDivisors(309483));
            Assert.AreEqual(8, Divisors.CountDivisors(225845));
            Assert.AreEqual(8, Divisors.CountDivisors(339485));
            Assert.AreEqual(24, Divisors.CountDivisors(96668));
            Assert.AreEqual(2, Divisors.CountDivisors(9739));
            Assert.AreEqual(4, Divisors.CountDivisors(56402));
            Assert.AreEqual(16, Divisors.CountDivisors(377082));
            Assert.AreEqual(72, Divisors.CountDivisors(55200));
            Assert.AreEqual(24, Divisors.CountDivisors(305396));
            Assert.AreEqual(4, Divisors.CountDivisors(284938));
            Assert.AreEqual(2, Divisors.CountDivisors(80231));
            Assert.AreEqual(54, Divisors.CountDivisors(285948));
       }
    }
}
