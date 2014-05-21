using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    /// <summary>
    /// 橡皮鸭 吱吱叫
    /// </summary>
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squack");
        }
    }
}
