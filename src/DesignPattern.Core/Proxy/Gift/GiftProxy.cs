using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Proxy.Gift
{
    public class GiftProxy : IGiveGift
    {
        public PurSuit Boy { get; set; }

        public GiftProxy(SchoolGirl girl)
        {
            Boy = new PurSuit(girl);
        }
        public void GiveDolls()
        {
            Boy.GiveDolls();
        }

        public void GiveFlowers()
        {
            Boy.GiveFlowers();
        }

        public void GiveChocolate()
        {
            Boy.GiveChocolate();
        }
    }
}
