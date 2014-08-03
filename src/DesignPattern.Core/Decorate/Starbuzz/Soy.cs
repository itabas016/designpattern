using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public class Soy : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
            this.Description = beverage.Description + ", Soy";
            this.Size = BeverageSize.GRANDE;
        }

        public override double Cost()
        {
            double cost = Beverage.Cost();

            switch (Size)
            {
                case BeverageSize.TALL:
                    cost += .10;
                    break;
                case BeverageSize.GRANDE:
                    cost += .15;
                    break;
                case BeverageSize.VENTI:
                    cost += .20;
                    break;
                default:
                    break;
            }
            return cost;
        }
    }
}
