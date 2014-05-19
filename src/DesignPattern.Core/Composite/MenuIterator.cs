using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Composite
{
    public class MenuIterator : Iterator
    {
        public List<MenuComponent> MenuComponents { get; set; }
        public int position = 0;

        public MenuIterator(List<MenuComponent> menuComponents)
        {
            this.MenuComponents = menuComponents;
        }

        public bool HasNext()
        {
            if (MenuComponents[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuComponent menuComponent = MenuComponents[position];
            position++;
            return menuComponent;
        }
    }
}
