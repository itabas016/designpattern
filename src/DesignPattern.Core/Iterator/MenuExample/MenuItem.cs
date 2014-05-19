using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Iterator.MenuExample
{
    public class MenuItem
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Vegetarian { get; set; }

        public double Price { get; set; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Vegetarian = vegetarian;
            this.Price = price;
        }
    }
}
