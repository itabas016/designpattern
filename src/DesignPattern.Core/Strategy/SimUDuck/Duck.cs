using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }

        public IQuackBehaivor quackBehavior { get; set; }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehaivor qb)
        {
            this.quackBehavior = qb;
        }
    }
}
