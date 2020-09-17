using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_OF_MULTIPLIER
{
    public static class InputValidator
    {
        public static void CheckNullTxtBox(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new FormatException($"Input is empty, try again.");
            }
        }
        public static void CheckRange(int input)
        {
            if (input < 1000 || input > 100000)
            {
                throw new FormatException($"Write a number between 10 and 100.000.");
            }
        }
    }
}
