using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Iterator.MenuExample;
using Xunit;

namespace DesignPattern.Test.Iterator
{
    public class MenuExampleTest
    {
        [Fact]
        public void WaitressPrintTest()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}
