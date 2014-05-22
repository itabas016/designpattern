using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class GooseFactory : AbstractGooseFactory
    {
        public override IQuackable CreateGoose()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
