using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6Prob2
{
    internal class Fibonacci
    {
        public static int FibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
            }
        }
    }
}
