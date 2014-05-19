using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.State.GumBallExample
{
    public class HasQuarterState : IState
    {
        public NewGumBallMachine Machine { get; set; }

        public HasQuarterState(NewGumBallMachine machine)
        {
            this.Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned.");
            Machine.SetState(Machine._NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned.....");
            Machine.SetState(Machine._SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
