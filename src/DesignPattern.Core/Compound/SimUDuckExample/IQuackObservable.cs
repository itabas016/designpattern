using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void notifyObservers();
    }
}
