using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Function.Test.Common
{
    public class GenericTest
    {
        [Fact]
        public void ListvsArrayList()
        {
            var l1 = new List<String>();
            ArrayList l2 = new ArrayList();

            l2.Add(1);
            l2.Add("I'm two");
            l2.Add(new List<int> { 3, 4, 5 });

            foreach (var item in l2)
            {
                Console.WriteLine(item);
            }

            l2.RemoveAt(0);
            l2.Insert(0, "1");

            Console.WriteLine(l2[0]);
            Console.WriteLine("The type is " + l2[0].GetType());

        }
    }
}
