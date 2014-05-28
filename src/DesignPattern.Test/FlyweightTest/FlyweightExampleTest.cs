using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Flyweight.Structural;
using Xunit;

namespace DesignPattern.Test.FlyweightTest
{
    public class FlyweightExampleTest
    {
        [Fact]
        public void StructuralTest()
        {
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
        }
    }
}
