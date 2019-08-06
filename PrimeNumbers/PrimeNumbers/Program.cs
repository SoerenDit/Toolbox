using System;

namespace PrimeNumbers
{
    class Program
    {
        private static int[] PrimeNumbers(int xthPrime)
        {
            var primeNumbers = new int[xthPrime-1];

            primeNumbers[0] = 2;
            var n = 0;
            var num = 3;

            while (n < xthPrime - 1)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (num % primeNumbers[i] == 0)
                    {
                        break;
                    }
                    if (i == n)
                    {
                        n++;
                        primeNumbers[n] = num;
                    }
                }
                num += 2;
            }
            return primeNumbers;
        }
    }
}
