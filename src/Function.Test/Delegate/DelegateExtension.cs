using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Test.Delegate
{
    public class DelegateExtension
    {
        public static void FeedBackToConsole(Int32 value)
        {
            Console.WriteLine("Item=" + value);
        }

        public void FeedBackToFile(Int32 value)
        {
            using (StreamWriter sw = new StreamWriter("Status", true))
            {
                sw.WriteLine("Item=" + value);
            }
        }
    }
}
