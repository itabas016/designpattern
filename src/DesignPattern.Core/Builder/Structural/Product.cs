using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Core.Builder.Structural
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Products Parts...");
            foreach (var item in _parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
