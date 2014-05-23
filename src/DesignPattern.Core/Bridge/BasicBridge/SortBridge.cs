using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public class SortBridge : ListBridge
    {
        public SortBridge(IVisList visList)
            :base(visList)
        {

        }

        public override void AddData(List<IVisList> list)
        {
            int max = list.Count;
            Product[] product = new Product[max];
            for (int i = 0; i < max; i++)
            {
                product[i] = (Product)list[i];
            }
            for (int i = 0; i < max; i++)
            {
                for (int j = i; j < max; j++)
                {
                    if (product[i].CompareTo(product[j]) > 0)
                    {
                        Product pt = product[i];
                        product[i] = product[j];
                        product[j] = pt;
                    }
                }
            }
            for (int i = 0; i < max; i++)
            {
                VisList.AddLine(product[i]);
            }  
        }
    }
}
