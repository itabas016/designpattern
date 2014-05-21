using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    /// <summary>
    /// 鸭子模拟器
    /// </summary>
    public class DuckSimulator
    {
        public void Simulate()
        {
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
            IQuackable duckCall = new QuackCounter(new DuckCall());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());

            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine("The Ducks quacked {0} times", QuackCounter.numberOfQuacks);
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
