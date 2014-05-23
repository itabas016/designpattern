using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.ProtoType.Structural;
using Xunit;

namespace DesignPattern.Test.ProtoTypeTest
{
    public class ProtoTypeExampleTest
    {
        [Fact]
        public void StructuralTest()
        {
            ConcreteProtoType protoType = new ConcreteProtoType("I");
            ConcreteProtoType c1 = (ConcreteProtoType)protoType.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcreteProtoType2 protoType2 = new ConcreteProtoType2("II");
            ConcreteProtoType2 c2 = (ConcreteProtoType2)protoType2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
        }
    }
}
