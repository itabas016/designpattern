using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.ProtoType.Structural
{
    public class ConcreteProtoType : ProtoTypeBase
    {
        public ConcreteProtoType(string id)
            : base(id)
        {

        }
        public override ProtoTypeBase Clone()
        {
            return (ProtoTypeBase)this.MemberwiseClone();
        }
    }
}
