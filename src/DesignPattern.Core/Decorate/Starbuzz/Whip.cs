using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public class Whip : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
            this.Description = beverage.Description + " , Whip";
        }

        public override double Cost()
        {
            return 0.10 + Beverage.Cost();
        }
    }
}
