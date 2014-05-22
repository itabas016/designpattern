using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class ListBridge : IBridge
    {
        public IVisList VisList { get; set; }

        public ListBridge(IVisList list)
        {
            this.VisList = list;
        }

        public void AddData(List<IVisList> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Product product = (Product)list[i];
                VisList.AddLine(product);
            }
        }
    }
}
