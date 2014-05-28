using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Core.Flyweight.Structural
{
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: {0}", extrinsicstate);
        }
    }
}
