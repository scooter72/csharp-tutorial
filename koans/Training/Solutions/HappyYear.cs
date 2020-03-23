using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Koans.Training.Solutions
{
    [TestClass]
    public class HappyYear
    {
        public static int NextHappyYear(int year)
        {
            while (true)
            {
                year++;
                var digits = year.ToString();
                if (digits[0] != digits[1] && digits[0] != digits[2] && digits[0] != digits[3] && digits[1] != digits[2] && digits[1] != digits[3] && digits[2] != digits[3])
                {
                    return year;
                }
            }
        }
    }
}
