using System;

namespace Koans.Training.Solutions
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            string[] voweles = new string[] { "a", "e", "i", "o", "u" };

            foreach (var vowel in voweles)
            {
                var index = str.IndexOf(vowel);

                while (index > -1)
                {
                    vowelCount++;
                    index = str.IndexOf(vowel, index + 1);
                }
            }

            return vowelCount;
        }
    }
}
