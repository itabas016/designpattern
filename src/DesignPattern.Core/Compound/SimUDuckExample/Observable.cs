using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class Observable : IQuackObservable
    {
        public List<IObserver> Observers { get; set; }

        public IQuackObservable Duck { get; set; }

        public Observable(IQuackObservable duck)
        {
            this.Duck = duck;
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void notifyObservers()
        {
            Iterator iterator = CreateIterator();
            while (iterator.HasNext())
            {
                IObserver observer = (IObserver)iterator.Next();
                observer.Update(Duck);
            }
        }

        public Iterator CreateIterator()
        {
            return new ObserverIterator(Observers);
        }
    }
}
