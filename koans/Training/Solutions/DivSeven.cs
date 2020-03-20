namespace Koans.Training.Solutions
{
    public class DivSeven
    {
        public static long[] Seven(long m)
        {
            int step = 0;

            while (m > 99)
            {
                m = m / 10 - m % 10 * 2;
                step++;
            }

            return new long[] { m, step };
        }
    }
}
