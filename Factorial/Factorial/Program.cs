using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        private static BigInteger Factorial(int number)
        {
            var factorial = (BigInteger)1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
