using System;
using System.Numerics;

namespace DigitSum
{
    class Program
    {
        private static object DigitSum(BigInteger longNumber)
        {
            string text = longNumber.ToString();
            var sum = 0;

            foreach (char c in text)
            {
                sum += c - '0';
            }
            return sum;
        }
    }
}
