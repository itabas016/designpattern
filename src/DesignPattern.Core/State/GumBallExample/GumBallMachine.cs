using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.State.GumBallExample
{
    public class GumBallMachine
    {
        public static readonly int SOLD_OUT = 0;
        public static readonly int NO_QUARTER = 1;
        public static readonly int HAS_QUARTER = 2;
        public static readonly int SOLD = 3;

        public int STATE = SOLD_OUT;
        public int COUNT = 0;

        public GumBallMachine(int count)
        {
            this.COUNT = count;
            if (count > 0)
            {
                STATE = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (STATE == HAS_QUARTER)
            {
                Console.WriteLine("You can't insert another quarter.");
            }
            else if (STATE == NO_QUARTER)
            {
                STATE = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter.");
            }
            else if (STATE == SOLD_OUT)
            {
                Console.WriteLine("You can't insert a quarter. the machine is sold out.");
            }
            else if (STATE == SOLD)
            {
                Console.WriteLine("Please wait, we're already giving you gumball.");
            }
        }

        public void EjectQuarter()
        {
            if (STATE == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned.");
                STATE = NO_QUARTER;
            }
            else if (STATE == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter.");
            }
            else if (STATE == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
            }
            else if (STATE == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank.");
            }
        }

        public void TurnCrank()
        {
            if (STATE == SOLD)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball.");
            }
            else if (STATE == NO_QUARTER)
            {
                Console.WriteLine("You turned but there is no quarter.");
            }
            else if (STATE == SOLD_OUT)
            {
                Console.WriteLine("You turned but there is no gumballs.");
            }
            else if (STATE == HAS_QUARTER)
            {
                Console.WriteLine("You turned.....");
                STATE = SOLD;
                Dispense();
            }
        }

        public void Dispense()
        {
            if (STATE == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                COUNT--;
                if (COUNT == 0)
                {
                    Console.WriteLine("Oops, out of gumballs.");
                    STATE = SOLD_OUT;
                }
                else
                {
                    STATE = NO_QUARTER;
                }
            }
            else if (STATE == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first.");
            }
            else if (STATE == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed.");
            }
            else if (STATE == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed");
            }
        }
    }
}
