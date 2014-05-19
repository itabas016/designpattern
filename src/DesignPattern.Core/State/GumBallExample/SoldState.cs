using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.State.GumBallExample
{
    public class SoldState : IState
    {
        public NewGumBallMachine Machine { get; set; }

        public SoldState(NewGumBallMachine machine)
        {
            this.Machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you gumball.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball.");
        }

        public void Dispense()
        {
            Machine.ReleaseBall();
            if (Machine.COUNT > 0)
            {
                Machine.SetState(Machine._NoQuarterState);
            }
            else
            {
                Machine.OutofBall();
                Machine.SetState(Machine._SoldOutState);
            }
        }
    }
}
