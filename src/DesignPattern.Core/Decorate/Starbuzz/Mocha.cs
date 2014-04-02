using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        public Beverage beverage { get; set; }

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public double Cost()
        {
            return 0.20 + beverage.Cost();
        }
    }
}
