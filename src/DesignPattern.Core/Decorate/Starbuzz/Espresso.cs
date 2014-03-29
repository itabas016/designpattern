using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    /// <summary>
    /// 浓缩咖啡
    /// </summary>
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso Coffee";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
