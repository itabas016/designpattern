using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Proxy.Gift;
using Xunit;

namespace DesignPattern.Test.Proxy
{
    public class GiftTest
    {
        [Fact]
        public void GiftProxyTest()
        {
            var schoolGirl = new SchoolGirl("Alice");
            var giftProxy = new GiftProxy(schoolGirl);

            giftProxy.GiveDolls();
            giftProxy.GiveFlowers();
            giftProxy.GiveChocolate();
        }
    }
}
