using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Template.StarbuzzExample
{
    public class Coffee : CoffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk.");
        }
    }
}
