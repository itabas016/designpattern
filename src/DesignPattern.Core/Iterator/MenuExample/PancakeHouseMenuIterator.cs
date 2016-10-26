using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Iterator.MenuExample
{
    public class PancakeHouseMenuIterator : Iterator
    {
        public List<MenuItem> MenuItemList { get; set; }
        private int postion = 0;

        public PancakeHouseMenuIterator(List<MenuItem> menulist)
        {
            this.MenuItemList = menulist;
        }

        public bool HasNext()
        {
            if (postion >= MenuItemList.Count)
            {
                return false;
            }
            else
            {
                if (MenuItemList[postion] == null)
                {
                    return false;
                }
                return true;
            }
        }

        public object Next()
        {
            MenuItem menuItem = MenuItemList[postion];
            postion++;
            return menuItem;
        }
    }
}
