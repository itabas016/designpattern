using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class Product : IComparable
    {
        public string Quantity { get; set; }

        public string Name { get; set; }

        public Product(string line)
        {
            int i = line.IndexOf("--");
            Name = line.Substring(0, i).Trim();
            Quantity = line.Substring(i + 2).Trim();
        }

        int IComparable.CompareTo(object obj)
        {
            Product product = (Product)obj;
            return Name.CompareTo(product.Name);
        }
    }
}
