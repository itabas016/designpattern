using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public class Milk : CondimentDecorator
    {
        public Beverage beverage { get; set; }

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public double Cost()
        {
            return 0.20 + beverage.Cost();
        }
    }
}
