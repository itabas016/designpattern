using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Test.Delegate
{
    public class MyDelegate
    {
        public void StaticDelegateDemo()
        {
            Console.WriteLine("----- Static Delegate Demo -----");
            DelegateFactory.Counter(1, 3, null);
            DelegateFactory.Counter(1, 3, new FeedBack(DelegateExtension.FeedBackToConsole));
            Console.WriteLine();
        }

        public void InstanceDelegateDemo()
        {
            Console.WriteLine("----- Instance Delegate Demo -----");
            DelegateExtension p = new DelegateExtension();
            DelegateFactory.Counter(1,3, new FeedBack(p.FeedBackToFile));
            Console.WriteLine();
        }

        public void ChainDelegateDemo1(DelegateExtension p)
        {
            Console.WriteLine("----- Chain Delegate Demo 1 -----");
            FeedBack fb1 = new FeedBack(DelegateExtension.FeedBackToConsole);
            FeedBack fb2 = new FeedBack(p.FeedBackToFile);

            Console.WriteLine();
        }
    }
}
