using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPattern.Test.Common
{
    public class CommonTest
    {
        [Fact]
        public void FactorialTest()
        {
            var ret = FactorialResursive(3);
            var ret2 = FactorialNonResursive(3);
            Console.WriteLine(ret);
            Console.WriteLine(ret2);
        }

        [Fact]
        public void FibonacciTest()
        {
            var ret = FibonacciResursive(6);
            var ret2 = FibonacciNonResursive(6);
            Console.WriteLine(ret);
            Console.WriteLine(ret2);
        }

        #region Factorial

        //n! recursive
        public static int FactorialResursive(int n)
        {
            var result = 0;
            if (n == 0)
            {
                result = 0;
            }
            else if (n == 1)
            {
                result = 1;
            }
            else
            {
                result = n * FactorialResursive(n - 1);
            }
            return result;
        }

        //n! for nonrecursive
        public int FactorialNonResursive(int n)
        {
            var sum = 1;

            if (n == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 1; i < n + 1; i++)
                {
                    sum *= i;
                }
            }
            return sum;
        }

        #endregion

        #region Fibonacci

        //Resursive
        public int FibonacciResursive(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            if (n >= 2)
            {
                return FibonacciResursive(n - 1) + FibonacciResursive(n - 2);
            }
            return 0;
        }

        //NonResursive
        public int FibonacciNonResursive(int n)
        {
            var sum = 0;
            if (n == 0 || n == 1)
            {
                sum = 1;
            }
            if (n >= 2)
            {
                var n_0 = 1;
                var n_1 = 1;
                for (int i = 2; i <= n; i++)
                {
                    sum = n_0;
                    n_0 = n_1;
                    n_1 = sum + n_0;
                    sum = n_1;
                }
            }
            return sum;
        }

        #endregion
    }
}
