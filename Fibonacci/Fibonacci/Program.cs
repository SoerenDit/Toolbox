using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {     
        private static List<int> Fibonacci(int highestFiboToBeFound)
        {
            var fibo = new List<int> { 1, 2 };
            int i = 1;

            while (fibo[i] <= highestFiboToBeFound)
            {
                i += 1;
                fibo.Add(fibo[i - 2] + fibo[i - 1]);
            }
            return fibo;
        }       
    }
}
