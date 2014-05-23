using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class ObserverIterator : Iterator
    {
        public List<IObserver> Observers { get; set; }

        public int position = 0;

        public ObserverIterator(List<IObserver> observers)
        {
            this.Observers = observers;
        }
        public object Next()
        {
            IObserver observer = Observers[position];
            position++;
            return observer;
        }

        public bool HasNext()
        {
            if (Observers.Count <= position)
            {
                return false;
            }
            return true;
        }
    }
}
