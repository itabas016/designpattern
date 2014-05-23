using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class Flock : IQuackable
    {
        public List<IQuackable> Quackers { get; set; }

        public Flock()
        {
            Quackers = new List<IQuackable>();
        }

        public void Add(IQuackable quack)
        {
            Quackers.Add(quack);
        }

        public void Quack()
        {
            Iterator iterator = CreateIterator();
            while (iterator.HasNext())
            {
                IQuackable quacker = (IQuackable)iterator.Next();
                quacker.Quack();
            }
        }

        public Iterator CreateIterator()
        {
            return new QuackIterator(Quackers);
        }

        public void RegisterObserver(IObserver observer)
        {
            Iterator iterator = CreateIterator();
            while (iterator.HasNext())
            {
                IQuackable quacker = (IQuackable)iterator.Next();
                quacker.RegisterObserver(observer);
            }
        }

        public void notifyObservers()
        {

        }
    }
}
