using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            //not do anything and not fly
            Console.WriteLine("I can't fly!");
        }
    }
}
