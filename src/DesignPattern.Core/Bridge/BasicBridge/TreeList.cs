using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class TreeList : IVisList
    {
        public TreeView Tree { get; set; }

        public TreeAdapter TreeAdapter { get; set; }

        public TreeList(TreeView tree)
        {
            this.Tree = tree;
            this.TreeAdapter = new TreeAdapter(tree);
        }

        public void AddLine(Product product)
        {
            TreeAdapter.Add(product);
        }

        public void RemoveLine(int num)
        {
        }
    }
}
