using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    /// <summary>
    /// 橡皮鸭 吱吱叫
    /// </summary>
    public class RubberDuck : IQuackable
    {
        public Observable Observable { get; set; }

        public RubberDuck()
        {
            this.Observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squack");
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
