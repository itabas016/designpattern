using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Composite
{
    public class Menu : MenuComponent
    {
        public List<MenuComponent> MenuComponents { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Menu(string name, string description)
        {
            this.Description = description;
            this.Name = name;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponent.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponent.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)MenuComponents[i];
        }

        public override Iterator CreateIterator()
        {
            return new CompositeIterator(new MenuIterator(MenuComponents));
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
            throw new NotImplementedException();
        }

        public override bool GetIsVegetarian()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine(string.Format("Name:{0}", GetName()));
            Console.WriteLine(string.Format("Decription:{0}", GetDescription()));

            Iterator iterator = CreateIterator();
            while (iterator.HasNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.Next();
                menuComponent.Print();
            }
        }
    }
}
