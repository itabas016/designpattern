using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Composite
{
    public class Waitress
    {
        public MenuComponent AllMenus { get; set; }

        public Waitress(MenuComponent allMenus)
        {
            this.AllMenus = allMenus;
        }

        public void PrintMenu()
        {
            AllMenus.Print();
        }
    }
}
