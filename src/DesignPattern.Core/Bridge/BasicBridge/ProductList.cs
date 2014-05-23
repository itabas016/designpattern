using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class ProductList : IVisList
    {
        public ListBox ListBox { get; set; }

        public ProductList(ListBox listBox)
        {
            this.ListBox = listBox;
        }

        public void AddLine(Product product)
        {
            ListBox.Items.Add(product.Name);
        }

        public void RemoveLine(int num)
        {
            if (num >= 0 && num <ListBox.Items.Count)
            {
                ListBox.Items.Remove(num);
            }
        }
    }
}
