using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Composite
{
    public class CompositeIterator : Iterator
    {
        Stack stack = new Stack();

        public CompositeIterator(Iterator iterator)
        {
            stack.Push(iterator);
        }

        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                Iterator iterator = (Iterator)stack.Peek();
                if (!iterator.HasNext())
                {
                    stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public object Next()
        {
            if (HasNext())
            {
                Iterator iterator = (Iterator)stack.Peek();
                MenuComponent component = (MenuComponent)iterator.Next();
                if (component is Menu)
                {
                    stack.Push(component.CreateIterator());
                }
                return component;
            }
            else
            {
                return null;
            }
        }
    }
}
