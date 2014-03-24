using DesignPattern.Core.Strategy.SimUDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPattern.Test.Strategy
{
    public class SimUDuckTest
    {
        [Fact]
        public void MarllardDuckTest()
        {
            var duck = new MallardDuck();
            duck.PerformFly();
            duck.PerformQuack();
            duck.Display();
        }

        [Fact]
        public void ModelDuckBySetMethodTest()
        {
            var duck = new ModelDuck();
            duck.PerformFly();
            duck.SetFlyBehavior(new FlyRocketPowered());
            duck.PerformFly();
        }
    }
}
