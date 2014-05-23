using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class GooseAdapter : IQuackable
    {
        public Goose Goose { get; set; }

        public Observable Observable { get; set; }

        public GooseAdapter(Goose goose)
        {
            this.Goose = goose;
            this.Observable = new Observable(this);
        }

        public void Quack()
        {
            Goose.Honk();
            notifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observable.RegisterObserver(observer);
        }

        public void notifyObservers()
        {
            Observable.notifyObservers();
        }
    }
}
