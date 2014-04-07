using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test.Exercise
{
    public class ClassFamily
    {
        public void ClassTest()
        {
            var ia = new InternalA();
            var pa = new PublicA();
            var ib = new InternalB();
            var pb = new PublicB();
            var pc = new PublicC();

            Console.WriteLine(ib._d);
            pb.C();
        }
    }

    internal class InternalA
    {
        protected const Int32 _a = 1;

        protected void A()
        {
            Console.WriteLine("I`m protected method A for internal class A.");
        }
    }

    public class PublicA
    {
        private const Int32 _b = 2;

        private void B()
        {
            Console.WriteLine("I`m private method B for public class A.");
        }
    }

    internal class InternalB : InternalA
    {
        public readonly Int32 _d = 4;
    }

    public class PublicB : PublicA
    {
        internal const Int32 _c = 3;

        public void C()
        {
            Console.WriteLine("I`m public method C for public class B.");
        }
    }

    internal class PublicC : InternalA
    {
        protected void D()
        {
            Console.WriteLine("I`m protected method D for public class C.");
        }
    }

}
