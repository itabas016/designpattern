using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Composite
{
    public abstract class MenuComponent
    {
        public abstract void Add(MenuComponent menuComponent);

        public abstract void Remove(MenuComponent menuComponent);

        public abstract MenuComponent GetChild(int i);

        public abstract string GetName();

        public abstract string GetDescription();

        public abstract double GetPrice();

        public abstract bool GetIsVegetarian();

        public abstract void Print();

        public abstract Iterator CreateIterator();
    }
}
