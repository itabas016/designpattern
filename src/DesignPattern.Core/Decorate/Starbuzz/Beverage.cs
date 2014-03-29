using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
