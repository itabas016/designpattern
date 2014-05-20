using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.State.GumBallExample
{
    public class WinnerState : IState
    {
        public NewGumBallMachine Machine { get; set; }

        public WinnerState(NewGumBallMachine machine)
        {
            this.Machine = machine;
        }
        public void InsertQuarter()
        {
        }

        public void EjectQuarter()
        {
        }

        public void TurnCrank()
        {
        }

        public void Dispense()
        {
            Console.WriteLine("You're a winner! You get two gum balls for you quarter.");
            Machine.ReleaseBall();
            if (Machine.COUNT == 0)
            {
                Machine.SetState(Machine._SoldOutState);
            }
            else
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
}
