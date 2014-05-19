using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Composite
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public bool IsVegetarian { get; set; }

        public MenuItem(string name, string description, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }

        public override void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine(string.Format("Name:{0}", GetName()));
            if (GetIsVegetarian())
            {
                Console.WriteLine("v");
            }
            Console.WriteLine(string.Format("Price:{0}", GetPrice()));
            Console.WriteLine(string.Format("Decription:{0}", GetDescription()));
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool GetIsVegetarian()
        {
            return IsVegetarian;
        }

        public override Iterator CreateIterator()
        {
            return new NullIterator();
        }
    }
}
