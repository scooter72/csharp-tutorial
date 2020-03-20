using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans.Training.Solutions
{
    public class Divisors
    {
        public static int Solution(int n)
        {
            int count = 0;
            double sqrt = Math.Sqrt(n);
            for (int i = 1; i <= sqrt; ++i)
            {
                if (n % i == 0) count += 2;
                if (i == sqrt) --count;
            }
            return count;
        }
    }
}
