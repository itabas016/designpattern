using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class RealQuack : IQuackBehaivor
    {
        public void Quack()
        {
            //real quack
            Console.WriteLine("Quack...");
        }
    }
}
