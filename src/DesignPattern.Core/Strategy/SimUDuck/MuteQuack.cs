using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Strategy.SimUDuck
{
    public class MuteQuack : IQuackBehaivor
    {
        public void Quack()
        {
            //name is quack real is no sound
            Console.WriteLine("<<Silence>>");
        }
    }
}
