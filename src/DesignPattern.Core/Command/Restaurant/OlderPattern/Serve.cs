using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Command.Restaurant
{
    public class Serve
    {
        private Cooker cook;

        public void TakeOrder(List<Order> orderList) { }

        public void OrderUp()
        {
            cook.MakeBurger();
            cook.MakeShake();
        }
    }
}
