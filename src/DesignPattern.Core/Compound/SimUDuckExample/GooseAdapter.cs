using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class GooseAdapter : IQuackable
    {
        public Goose Goose { get; set; }

        public GooseAdapter(Goose goose)
        {
            this.Goose = goose;
        }

        public void Quack()
        {
            Goose.Honk();
        }
    }
}
