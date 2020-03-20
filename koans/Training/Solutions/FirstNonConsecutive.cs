using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans.Training.Solutions
{
    public class FirstNonConsecutive
    {
        public static object Solution(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (i + 1 == arr.Length) break;

                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1];
                }
            }
            return null;
        }
    }
}
