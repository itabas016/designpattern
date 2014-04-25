using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            //use the wings to fly
            Console.WriteLine("I'm flying!");
        }
    }
}
