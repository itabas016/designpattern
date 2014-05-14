using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Iterator.MenuExample
{
    public class Waitress
    {
        public PancakeHouseMenu PancakeHouseMenu { get; set; }
        public DinerMenu DinerMenu { get; set; }

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.DinerMenu = dinerMenu;
            this.PancakeHouseMenu = pancakeHouseMenu;
        }

        public void PrintMenu()
        {
            Iterator pancakeHouseIterator = PancakeHouseMenu.CreateIterator();
            Iterator dinerIterator = DinerMenu.CreateIterator();

            Console.WriteLine(" --- Breakfast Menu ---");
            PrintMenu(pancakeHouseIterator);

            Console.WriteLine(" --- Lunch Menu ---");
            PrintMenu(dinerIterator);
        }

        public void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine(string.Format("Menu Name: {0}\nMenu Description: {1}\nMenu Price: {2}",
                    menuItem.Name, menuItem.Description, menuItem.Price));
            }
        }
    }
}
