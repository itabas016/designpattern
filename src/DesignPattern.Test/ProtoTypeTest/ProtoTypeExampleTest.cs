using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.ProtoType.RealWorld;
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

        [Fact]
        public void RealWorldTest()
        {
            ColorManager colormanager = new ColorManager();

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;
        }
    }
}
