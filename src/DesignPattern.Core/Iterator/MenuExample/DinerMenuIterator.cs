using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Iterator.MenuExample
{
    public class DinerMenuIterator : Iterator
    {
        public MenuItem[] MenuItemArray { get; set; }
        private int postion = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.MenuItemArray = items;
        }

        public bool HasNext()
        {
            if (postion >= MenuItemArray.Length || MenuItemArray[postion] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem menuItem = MenuItemArray[postion];
            postion++;
            return menuItem;
        }
    }
}
