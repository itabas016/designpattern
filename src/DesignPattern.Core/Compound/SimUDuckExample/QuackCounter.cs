using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class QuackCounter : IQuackable
    {
        public IQuackable Duck { get; set; }

        public static int numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.Duck = duck;
        }

        public void Quack()
        {
            Duck.Quack();
            numberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            Duck.RegisterObserver(observer);
        }

        public void notifyObservers()
        {
            Duck.notifyObservers();
        }
    }
}
