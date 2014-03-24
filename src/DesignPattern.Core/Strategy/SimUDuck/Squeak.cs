using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class Squeak : IQuackBehaivor
    {
        public void Quack()
        {
            //name is quack real is squeak
            Console.WriteLine("Squeak...");
        }
    }
}
