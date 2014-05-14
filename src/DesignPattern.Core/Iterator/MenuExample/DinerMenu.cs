using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Iterator.MenuExample
{
    public class DinerMenu
    {
        public static readonly int MAX_ITEMS = 6;

        public int numberOfItems = 0;
        public MenuItem[] MenuItemArray { get; set; }

        public DinerMenu()
        {
            MenuItemArray = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            //Add other item
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full, Can't add item to menu");
            }
            else
            {
                MenuItemArray[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(MenuItemArray);
        }
    }
}
