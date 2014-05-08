using DesignPattern.Core.Strategy.SimUDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Adapter.DuckExample
{
    public class TurkeyAdpter : Duck, IFlyBehavior, IQuackBehaivor
    {
        public ITurkey Turkey { get; set; }

        public TurkeyAdpter(ITurkey turkey)
        {
            this.Turkey = turkey;
        }

        public override void Display()
        {
            Console.WriteLine("I'm Turkey Adapter");
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.Fly();
            }
        }

        public void Quack()
        {
            Turkey.Gobble();
        }
    }
}
