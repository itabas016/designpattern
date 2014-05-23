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

        #region Older method
        //public void Simulate()
        //{
        //    IQuackable mallardDuck = new QuackCounter(new MallardDuck());
        //    IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
        //    IQuackable duckCall = new QuackCounter(new DuckCall());
        //    IQuackable rubberDuck = new QuackCounter(new RubberDuck());

        //    IQuackable gooseDuck = new GooseAdapter(new Goose());

        //    Console.WriteLine("Duck Simulator");

        //    Simulate(mallardDuck);
        //    Simulate(redheadDuck);
        //    Simulate(duckCall);
        //    Simulate(rubberDuck);
        //    Simulate(gooseDuck);

        //    Console.WriteLine("The Ducks quacked {0} times", QuackCounter.numberOfQuacks);
        //} 

        #endregion

        public void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();

            IQuackable gooseDuck = gooseFactory.CreateGoose();

            Console.WriteLine("Duck Simulator : with Composite and Iterator method");

            Flock flockDucks = new Flock();
            flockDucks.Add(redheadDuck);
            flockDucks.Add(duckCall);
            flockDucks.Add(rubberDuck);
            flockDucks.Add(gooseDuck);

            Flock flockMallardDucks = new Flock();
            IQuackable mallardDuckOne = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardDuckThree = duckFactory.CreateMallardDuck();
            flockMallardDucks.Add(mallardDuck);
            flockMallardDucks.Add(mallardDuckOne);
            flockMallardDucks.Add(mallardDuckTwo);
            flockMallardDucks.Add(mallardDuckThree);

            flockDucks.Add(flockMallardDucks);

            Console.WriteLine("Duck Simulator: with observers.");

            Quackologist quackologist = new Quackologist();
            flockDucks.RegisterObserver(quackologist);

            Simulate(flockDucks);

            Console.WriteLine("Duck Simulator: Mallard Flock Simulation.");
            Simulate(flockMallardDucks);

            Console.WriteLine("The Ducks quacked {0} times", QuackCounter.numberOfQuacks);
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
