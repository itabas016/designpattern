using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Template.StarbuzzExample
{
    public class Tea : CoffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Stepping in the tea.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon.");
        }
    }
}
