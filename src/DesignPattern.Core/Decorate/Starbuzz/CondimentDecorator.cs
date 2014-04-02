using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();

        public override double Cost()
        {
            throw new NotImplementedException();
        }
    }
}
