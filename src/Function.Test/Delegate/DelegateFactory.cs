using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Test.Delegate
{
    internal delegate void FeedBack(Int32 value);

    internal class DelegateFactory
    {
        public static void Counter(Int32 from, Int32 to, FeedBack fb)
        {
            for (Int32 i = from; i < -to; i++)
            {
                if (fb != null)
                {
                    fb(i);
                }
            }
        }
    }
}
