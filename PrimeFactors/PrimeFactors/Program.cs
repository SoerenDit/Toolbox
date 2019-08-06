using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    class Program
    {
        private static List<int> PrimeFactor(long number)
        {
            var primeFactor = new List<int>();

            int div = 2;
            while (number != 1)
            {
                if (number % div == 0)
                {
                    primeFactor.Add(div);
                    number = number / div;
                    div--;
                }
                div++;
            }
            return primeFactor;
        }
    }
}
