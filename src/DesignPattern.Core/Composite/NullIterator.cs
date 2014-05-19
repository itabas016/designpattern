using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Core.Composite
{
    public class NullIterator : Iterator
    {
        public bool HasNext()
        {
            return false;
        }

        public object Next()
        {
            return null;
        }
    }
}
