using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Function.Test.Common
{
    public class YieldTest
    {
        [Fact]
        public void yield_return_test()
        {
            int[] s = new int[2];
            foreach (var item in List)
            {
                s[0] = item;
                GetEnumerator();
                s[1] = item;
            }

            Console.WriteLine(string.Format("{0}|{1}", s[0], s[1]));
        }

        private List<int> List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        private static IEnumerator<int> GetEnumerator()
        {
            yield return 4;
            yield return 8;
        }
    }
}
