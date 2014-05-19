using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Core.State.GumBallExample
{
    public class NewGumBallMachine
    {
        public IState _SoldOutState { get; set; }
        public IState _NoQuarterState { get; set; }
        public IState _HasQuarterState { get; set; }
        public IState _SoldState { get; set; }

        public IState STATE;
        public int COUNT = 0;

        public NewGumBallMachine(int numberGumballs)
        {
            _SoldOutState = new SoldOutState(this);
            _NoQuarterState = new NoQuarterState(this);
            _HasQuarterState = new HasQuarterState(this);
            _SoldState = new SoldState(this);

            STATE = _SoldOutState;
            this.COUNT = numberGumballs;
            if (numberGumballs > 0)
            {
                STATE = _NoQuarterState;
            }
        }

        public void SetState(IState state)
        {
            this.STATE = state;
        }

        public void InsertQuarter()
        {
            STATE.InsertQuarter();
        }

        public void EjectQuarter()
        {
            STATE.EjectQuarter();
        }

        public void TurnCrank()
        {
            STATE.TurnCrank();
            STATE.Dispense();
        }

        public void Dispense()
        {
            STATE.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot.");
            if (COUNT != 0)
            {
                COUNT--;
            }
        }

        public void OutofBall()
        {
            Console.WriteLine("Oops, out of gumballs.");
        }
    }
}
