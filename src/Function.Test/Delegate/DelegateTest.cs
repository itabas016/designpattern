using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Function.Test.Delegate
{
    public class DelegateTest
    {
        MyDelegate p = new MyDelegate();

        [Fact]
        public void delegate_static_instance_test()
        {
            p.StaticDelegateDemo();
            p.InstanceDelegateDemo();
        }
    }
}
