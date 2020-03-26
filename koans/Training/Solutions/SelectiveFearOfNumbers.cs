using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koans.Training.Solutions
{
    class SelectiveFearOfNumbers
    {
        public static bool AmIAfraid(string day, int num)
        {
            switch (day)
            {
                case "Monday":
                    return num == 12;
                case "Tuesday":
                    return num > 95;
                case "Wednesday":
                    return num == 34;
                case "Thursday":
                    return num == 0;
                case "Friday":
                    return num % 2 == 0;
                case "Saturday":
                    return num == 56;
                case "Sunday":
                    return num == 666 || num == -666;
            }
            return false;
        }
    }
}
