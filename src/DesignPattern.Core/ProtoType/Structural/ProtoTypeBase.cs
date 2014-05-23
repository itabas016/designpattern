using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.ProtoType.Structural
{
    public abstract class ProtoTypeBase
    {
        private string _id;

        public ProtoTypeBase(string id)
        {
            this._id = id;
        }

        public string Id { get { return _id; } }

        public abstract ProtoTypeBase Clone();
    }
}
