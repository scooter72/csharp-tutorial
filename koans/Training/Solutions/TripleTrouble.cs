using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans.Training.Solutions
{
    public class TripleTrouble
    {
        public static string Solution(string one, string two, string three)
        {
            string result = "";

            for (int i = 0; i < one.Length; ++i)
            {
                result += $"{one[i]}{two[i]}{three[i]}";
            }
            return result;
        }
    }
}
