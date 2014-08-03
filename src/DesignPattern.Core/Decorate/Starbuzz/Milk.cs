using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public class Milk : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Milk(Beverage beverage)
        {
            this.Beverage = beverage;
            this.Description = Beverage.Description + ", Milk";
        }

        public override double Cost()
        {
            return 0.20 + Beverage.Cost();
        }
    }
}
