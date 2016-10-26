using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Iterator.MenuExample
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItemList { get; set; }

        public PancakeHouseMenu()
        {
            MenuItemList = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", false, 2.99);
            AddItem("Blueberry Pancake", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItemList.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(MenuItemList);
        }
        //Other Methods
    }
}
