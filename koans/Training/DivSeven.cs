using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training
{
    /*
     A number m of the form 10x + y is divisible by 7 if and only if x − 2y is divisible by 7. In other words, 
     subtract twice the last digit from the number formed by the remaining digits. Continue to do this until a number known 
     to be divisible or not by 7 is obtained; you can stop when this number has at most 2 digits because you are supposed to 
     know if a number of at most 2 digits is divisible by 7 or not.
     
     The original number is divisible by 7 if and only if the last number obtained using this procedure is divisible by 7.
     
     Examples:
     1 - m = 371 -> 37 − (2×1) -> 37 − 2 = 35 ; thus, since 35 is divisible by 7, 371 is divisible by 7.
     The number of steps to get the result is 1.
     2 - m = 1603 -> 160 - (2 x 3) -> 154 -> 15 - 8 = 7 and 7 is divisible by 7.
     3 - m = 372 -> 37 − (2×2) -> 37 − 4 = 33 ; thus, since 33 is not divisible by 7, 372 is not divisible by 7.
     The number of steps to get the result is 1.
     4 - m = 477557101->47755708->4775554->477547->47740->4774->469->28 and 28 is divisible by 7, so is 477557101.
     The number of steps is 7.
     
        Task:
            Your task is to return to the function seven(m) (m integer >= 0) an array (or a pair, depending on the language) of numbers, 
            the first being the last number m with at most 2 digits obtained by your function (this last m will be divisible or not by 7), 
            the second one being the number of steps to get the result.
    */
    [TestClass]
    public class DivSeven
    {
        public static long[] Seven(long m)
        {
            return null;
        }

        [TestMethod]
        public void Test1()
        {
            Assert.IsTrue((new long[] { 10, 2 }).SequenceEqual(DivSeven.Seven(10)));
            Assert.IsTrue((new long[] { 28, 7 }).SequenceEqual(DivSeven.Seven(28)));
            Assert.IsTrue((new long[] { 47, 7 }).SequenceEqual(DivSeven.Seven(47)));
            Assert.IsTrue((new long[] { 21, 7 }).SequenceEqual(DivSeven.Seven(21)));
            Assert.IsTrue((new long[] { 7, 2 }).SequenceEqual(DivSeven.Seven(7)));
            Assert.IsTrue((new long[] { 35, 1 }).SequenceEqual(DivSeven.Seven(35)));
            Assert.IsTrue((new long[] { 0, 5 }).SequenceEqual(DivSeven.Seven(0)));
            Assert.IsTrue((new long[] { 42, 1 }).SequenceEqual(DivSeven.Seven(42)));
            Assert.IsTrue((new long[] { 28, 4 }).SequenceEqual(DivSeven.Seven(28)));
            Assert.IsTrue((new long[] { 0, 0 }).SequenceEqual(DivSeven.Seven(0)));
            Assert.IsTrue((new long[] { 7, 2 }).SequenceEqual(DivSeven.Seven(7)));
            Assert.IsTrue((new long[] { 29, 5 }).SequenceEqual(DivSeven.Seven(29)));
            Assert.IsTrue((new long[] { 54, 5 }).SequenceEqual(DivSeven.Seven(54)));
            Assert.IsTrue((new long[] { 24, 5 }).SequenceEqual(DivSeven.Seven(24)));
            Assert.IsTrue((new long[] { 8, 5 }).SequenceEqual(DivSeven.Seven(8)));
            Assert.IsTrue((new long[] { 14, 5 }).SequenceEqual(DivSeven.Seven(14)));
            Assert.IsTrue((new long[] { 16, 5 }).SequenceEqual(DivSeven.Seven(16)));
            Assert.IsTrue((new long[] { 21, 5 }).SequenceEqual(DivSeven.Seven(21)));
            Assert.IsTrue((new long[] { 10, 5 }).SequenceEqual(DivSeven.Seven(10)));
            Assert.IsTrue((new long[] { 31, 5 }).SequenceEqual(DivSeven.Seven(31)));
            Assert.IsTrue((new long[] { 51, 5 }).SequenceEqual(DivSeven.Seven(51)));
            Assert.IsTrue((new long[] { 47, 5 }).SequenceEqual(DivSeven.Seven(47)));
            Assert.IsTrue((new long[] { 28, 5 }).SequenceEqual(DivSeven.Seven(28)));
            Assert.IsTrue((new long[] { 14, 4 }).SequenceEqual(DivSeven.Seven(14)));
            Assert.IsTrue((new long[] { 8, 5 }).SequenceEqual(DivSeven.Seven(8)));
            Assert.IsTrue((new long[] { 65, 5 }).SequenceEqual(DivSeven.Seven(65)));
            Assert.IsTrue((new long[] { -7, 5 }).SequenceEqual(DivSeven.Seven(-7)));
            Assert.IsTrue((new long[] { 55, 3 }).SequenceEqual(DivSeven.Seven(55)));
            Assert.IsTrue((new long[] { 6, 5 }).SequenceEqual(DivSeven.Seven(6)));
            Assert.IsTrue((new long[] { 3, 5 }).SequenceEqual(DivSeven.Seven(3)));
            Assert.IsTrue((new long[] { 40, 5 }).SequenceEqual(DivSeven.Seven(40)));
            Assert.IsTrue((new long[] { 60, 5 }).SequenceEqual(DivSeven.Seven(60)));
            Assert.IsTrue((new long[] { 49, 5 }).SequenceEqual(DivSeven.Seven(49)));
            Assert.IsTrue((new long[] { 37, 5 }).SequenceEqual(DivSeven.Seven(37)));
            Assert.IsTrue((new long[] { 40, 5 }).SequenceEqual(DivSeven.Seven(40)));
            Assert.IsTrue((new long[] { 26, 5 }).SequenceEqual(DivSeven.Seven(26)));
            Assert.IsTrue((new long[] { 21, 5 }).SequenceEqual(DivSeven.Seven(21)));
            Assert.IsTrue((new long[] { 1, 5 }).SequenceEqual(DivSeven.Seven(1)));
            Assert.IsTrue((new long[] { 62, 5 }).SequenceEqual(DivSeven.Seven(62)));
            Assert.IsTrue((new long[] { 1, 5 }).SequenceEqual(DivSeven.Seven(1)));
            Assert.IsTrue((new long[] { 26, 5 }).SequenceEqual(DivSeven.Seven(26)));
            Assert.IsTrue((new long[] { 33, 5 }).SequenceEqual(DivSeven.Seven(33)));
            Assert.IsTrue((new long[] { 4, 4 }).SequenceEqual(DivSeven.Seven(4)));
            Assert.IsTrue((new long[] { 50, 5 }).SequenceEqual(DivSeven.Seven(50)));
            Assert.IsTrue((new long[] { 0, 5 }).SequenceEqual(DivSeven.Seven(0)));
            Assert.IsTrue((new long[] { 43, 5 }).SequenceEqual(DivSeven.Seven(43)));
            Assert.IsTrue((new long[] { 55, 5 }).SequenceEqual(DivSeven.Seven(55)));
            Assert.IsTrue((new long[] { 26, 5 }).SequenceEqual(DivSeven.Seven(26)));
            Assert.IsTrue((new long[] { 33, 5 }).SequenceEqual(DivSeven.Seven(33)));
            Assert.IsTrue((new long[] { 29, 5 }).SequenceEqual(DivSeven.Seven(29)));
            Assert.IsTrue((new long[] { 29, 5 }).SequenceEqual(DivSeven.Seven(29)));
            Assert.IsTrue((new long[] { 55, 5 }).SequenceEqual(DivSeven.Seven(55)));
            Assert.IsTrue((new long[] { 20, 5 }).SequenceEqual(DivSeven.Seven(20)));
            Assert.IsTrue((new long[] { 65, 5 }).SequenceEqual(DivSeven.Seven(65)));
            Assert.IsTrue((new long[] { 10, 5 }).SequenceEqual(DivSeven.Seven(10)));
            Assert.IsTrue((new long[] { 56, 5 }).SequenceEqual(DivSeven.Seven(56)));
            Assert.IsTrue((new long[] { 31, 5 }).SequenceEqual(DivSeven.Seven(31)));
            Assert.IsTrue((new long[] { 51, 5 }).SequenceEqual(DivSeven.Seven(51)));
            Assert.IsTrue((new long[] { 58, 5 }).SequenceEqual(DivSeven.Seven(58)));
            Assert.IsTrue((new long[] { 53, 5 }).SequenceEqual(DivSeven.Seven(53)));
            Assert.IsTrue((new long[] { 14, 5 }).SequenceEqual(DivSeven.Seven(14)));
            Assert.IsTrue((new long[] { 44, 5 }).SequenceEqual(DivSeven.Seven(44)));
            Assert.IsTrue((new long[] { 60, 5 }).SequenceEqual(DivSeven.Seven(60)));
            Assert.IsTrue((new long[] { 45, 5 }).SequenceEqual(DivSeven.Seven(45)));
            Assert.IsTrue((new long[] { 6, 5 }).SequenceEqual(DivSeven.Seven(6)));
            Assert.IsTrue((new long[] { 15, 5 }).SequenceEqual(DivSeven.Seven(15)));
            Assert.IsTrue((new long[] { 45, 5 }).SequenceEqual(DivSeven.Seven(45)));
            Assert.IsTrue((new long[] { 9, 5 }).SequenceEqual(DivSeven.Seven(9)));
            Assert.IsTrue((new long[] { 38, 5 }).SequenceEqual(DivSeven.Seven(38)));
            Assert.IsTrue((new long[] { 57, 5 }).SequenceEqual(DivSeven.Seven(57)));
            Assert.IsTrue((new long[] { 68, 5 }).SequenceEqual(DivSeven.Seven(68)));
            Assert.IsTrue((new long[] { 54, 4 }).SequenceEqual(DivSeven.Seven(54)));
            Assert.IsTrue((new long[] { 24, 5 }).SequenceEqual(DivSeven.Seven(24)));
            Assert.IsTrue((new long[] { 12, 5 }).SequenceEqual(DivSeven.Seven(12)));
            Assert.IsTrue((new long[] { 96, 4 }).SequenceEqual(DivSeven.Seven(96)));
            Assert.IsTrue((new long[] { 21, 5 }).SequenceEqual(DivSeven.Seven(21)));
            Assert.IsTrue((new long[] { 37, 5 }).SequenceEqual(DivSeven.Seven(37)));
            Assert.IsTrue((new long[] { 32, 5 }).SequenceEqual(DivSeven.Seven(32)));
            Assert.IsTrue((new long[] { 47, 5 }).SequenceEqual(DivSeven.Seven(47)));
            Assert.IsTrue((new long[] { 19, 5 }).SequenceEqual(DivSeven.Seven(19)));
            Assert.IsTrue((new long[] { 13, 5 }).SequenceEqual(DivSeven.Seven(13)));
            Assert.IsTrue((new long[] { 32, 5 }).SequenceEqual(DivSeven.Seven(32)));
            Assert.IsTrue((new long[] { 21, 5 }).SequenceEqual(DivSeven.Seven(21)));
            Assert.IsTrue((new long[] { 42, 5 }).SequenceEqual(DivSeven.Seven(42)));
            Assert.IsTrue((new long[] { 60, 5 }).SequenceEqual(DivSeven.Seven(60)));
            Assert.IsTrue((new long[] { 60, 5 }).SequenceEqual(DivSeven.Seven(60)));
            Assert.IsTrue((new long[] { 32, 5 }).SequenceEqual(DivSeven.Seven(32)));
            Assert.IsTrue((new long[] { 59, 5 }).SequenceEqual(DivSeven.Seven(59)));
            Assert.IsTrue((new long[] { -2, 5 }).SequenceEqual(DivSeven.Seven(-2)));
            Assert.IsTrue((new long[] { 49, 5 }).SequenceEqual(DivSeven.Seven(49)));
            Assert.IsTrue((new long[] { -2, 5 }).SequenceEqual(DivSeven.Seven(-2)));
            Assert.IsTrue((new long[] { 35, 5 }).SequenceEqual(DivSeven.Seven(35)));
            Assert.IsTrue((new long[] { 18, 5 }).SequenceEqual(DivSeven.Seven(18)));
            Assert.IsTrue((new long[] { 52, 4 }).SequenceEqual(DivSeven.Seven(52)));
            Assert.IsTrue((new long[] { 52, 5 }).SequenceEqual(DivSeven.Seven(52)));
            Assert.IsTrue((new long[] { 36, 5 }).SequenceEqual(DivSeven.Seven(36)));
            Assert.IsTrue((new long[] { 48, 5 }).SequenceEqual(DivSeven.Seven(48)));
            Assert.IsTrue((new long[] { 12, 5 }).SequenceEqual(DivSeven.Seven(12)));
            Assert.IsTrue((new long[] { 26, 5 }).SequenceEqual(DivSeven.Seven(26)));
            Assert.IsTrue((new long[] { 50, 5 }).SequenceEqual(DivSeven.Seven(50)));
            Assert.IsTrue((new long[] { 63, 5 }).SequenceEqual(DivSeven.Seven(63)));
            Assert.IsTrue((new long[] { 38, 5 }).SequenceEqual(DivSeven.Seven(38)));
            Assert.IsTrue((new long[] { 42, 5 }).SequenceEqual(DivSeven.Seven(42)));
            Assert.IsTrue((new long[] { 51, 5 }).SequenceEqual(DivSeven.Seven(51)));
            Assert.IsTrue((new long[] { 36, 5 }).SequenceEqual(DivSeven.Seven(36)));
            Assert.IsTrue((new long[] { 24, 5 }).SequenceEqual(DivSeven.Seven(24)));
            Assert.IsTrue((new long[] { 13, 5 }).SequenceEqual(DivSeven.Seven(13)));
            Assert.IsTrue((new long[] { 26, 4 }).SequenceEqual(DivSeven.Seven(26)));
            Assert.IsTrue((new long[] { 39, 5 }).SequenceEqual(DivSeven.Seven(39)));
            Assert.IsTrue((new long[] { 4, 4 }).SequenceEqual(DivSeven.Seven(4)));
            Assert.IsTrue((new long[] { 22, 5 }).SequenceEqual(DivSeven.Seven(22)));
        }
    }
}
