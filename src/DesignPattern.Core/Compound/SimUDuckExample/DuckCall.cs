using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    /// <summary>
    /// 鸭鸣器 假声
    /// </summary>
    public class DuckCall : IQuackable
    {
        public Observable Observable { get; set; }

        public DuckCall()
        {
            this.Observable = new Observable(this);

        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            notifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.Observable.RegisterObserver(observer);
        }

        public void notifyObservers()
        {
            this.Observable.notifyObservers();
        }
    }
}
