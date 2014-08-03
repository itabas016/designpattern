using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    /// <summary>
    /// 混合综合咖啡
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
