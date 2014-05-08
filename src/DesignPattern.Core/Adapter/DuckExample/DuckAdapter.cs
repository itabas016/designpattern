using DesignPattern.Core.Strategy.SimUDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Adapter.DuckExample
{
    public class DuckAdapter : ITurkey
    {
        public Duck Duck { get; set; }
        Random random;

        public DuckAdapter(Duck duck)
        {
            this.Duck = duck;
        }

        public void Gobble()
        {
            Duck.PerformQuack();
        }

        public void Fly()
        {
            if (random.Next(5) == 0)
            {
                Duck.PerformFly();
            }
        }
    }
}
