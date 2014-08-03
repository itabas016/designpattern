using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public abstract class CondimentDecorator : Beverage
    {
        public BeverageSize Size { get; set; }

        public abstract override double Cost();
    }
}
