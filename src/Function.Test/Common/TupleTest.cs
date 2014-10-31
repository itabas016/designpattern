using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Function.Test.Common
{
    public class TupleTest
    {
        [Fact]
        public void tuple_use_test()
        {
            Tuple<int> t1 = new Tuple<int>(1);

            Tuple<int, int> t2 = Tuple.Create<int, int>(1, 3);

            Tuple<int, Tuple<int, int>> t3 = new Tuple<int, Tuple<int, int>>(1, Tuple.Create<int, int>(1, 3));

            Console.WriteLine(t1.Item1);
            Console.WriteLine(t2.Item1 + t2.Item2);
            Console.WriteLine(t3.Item1 + (t3.Item2.Item1 + t3.Item2.Item2));
        }
    }
}
