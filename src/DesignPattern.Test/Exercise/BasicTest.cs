using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test.Exercise
{
    public class BasicTest
    {
        public void ReferenceAndValueTypeTest()
        {
            var v1 = new SomeValue();
            var r1 = new SomeReference();
            v1.Value = 5;
            r1.Value = 5;

            var v2 = v1;
            var r2 = r1;

            v1.Value = 8;
            r1.Value = 9;

            Console.WriteLine(v1.Value);
            Console.WriteLine(v2.Value);
            Console.WriteLine(r1.Value);
            Console.WriteLine(r2.Value);
        }
    }

    public struct SomeValue
    {
        public int Value { get; set; }
    }

    public class SomeReference
    {
        public int Value { get; set; }
    }
}
