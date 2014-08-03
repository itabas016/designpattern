using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    /// <summary>
    /// 低咖啡因咖啡
    /// </summary>
    public class Decat : Beverage
    {
        public Decat()
        {
            this.Description = "Decat Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
