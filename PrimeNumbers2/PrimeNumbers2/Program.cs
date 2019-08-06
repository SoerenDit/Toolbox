using System;
using System.Collections.Generic;

namespace PrimeNumbers2
{
    class Program
    {
        private static List<double> PrimeNumbers2(double maxPrime)
        {
            var primeNumbers = new List<double> { 2 };
            int num = 3;

            while (num < maxPrime)
            {
                for (int i = 0; i <= primeNumbers.Count - 1; i++)
                {
                    if (num % primeNumbers[i] == 0)
                    {
                        break;
                    }
                    if (i == primeNumbers.Count - 1)
                    {
                        primeNumbers.Add(num);
                    }
                }
                num += 2;
            }
            return primeNumbers;
        }
    }
}
