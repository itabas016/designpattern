using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.State.GumBallExample
{
    public class SoldOutState : IState
    {
        public NewGumBallMachine Machine { get; set; }

        public SoldOutState(NewGumBallMachine machine)
        {
            this.Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter. the machine is sold out.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there is no gumballs.");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }
    }
}
