using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Proxy.Gift
{
    public class PurSuit : IGiveGift
    {
        public SchoolGirl SchoolGirl { get; set; }

        public PurSuit(SchoolGirl girl)
        {
            this.SchoolGirl = girl;
        }

        public void GiveDolls()
        {
            Console.WriteLine("{0}:Give your dolls.", SchoolGirl.Name);
        }

        public void GiveFlowers()
        {
            Console.WriteLine("{0}:Give your flowers.", SchoolGirl.Name);
        }

        public void GiveChocolate()
        {
            Console.WriteLine("{0}:Give your chocolate.", SchoolGirl.Name);
        }
    }
}
