using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.State.GumBallExample
{
    public class NoQuarterState : IState
    {
        public NewGumBallMachine Machine { get; set; }

        public NoQuarterState(NewGumBallMachine machine)
        {
            this.Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            Machine.SetState(Machine._HasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there is no quarter.");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }
    }
}
