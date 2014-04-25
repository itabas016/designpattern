using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class ModelDuck :Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new RealQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
