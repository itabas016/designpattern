using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            //fly with rocket
            Console.WriteLine("I`m flying with the rocket!");
        }
    }
}
