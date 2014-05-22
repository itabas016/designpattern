using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class TreeAdapter
    {
        public TreeView Tree { get; set; }

        public TreeAdapter(TreeView tree)
        {
            this.Tree = tree;
        }

        public void Add(Product product)
        {
            TreeNode nod;
            nod = Tree.Nodes.Add(product.Name);
            nod.Nodes.Add(product.Quantity);
            Tree.ExpandAll();
        }

        public int SelectedIndex()
        {
            return Tree.SelectedNode.Index;
        }

        public void Clear()
        {
            TreeNode nod;
            for (int i = 0; i < Tree.Nodes.Count; i++)
            {
                nod = Tree.Nodes[i];
                nod.Remove();
            }
        }

        public void clearSelection() { }
    }
}
