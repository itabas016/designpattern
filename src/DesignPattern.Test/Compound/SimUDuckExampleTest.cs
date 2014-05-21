using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Compound.SimUDuckExample;
using Xunit;

namespace DesignPattern.Test.Compound
{
    public class SimUDuckExampleTest
    {
        [Fact]
        public void VariableDuckQuackTest()
        {
            var duckSimulator = new DuckSimulator();
            AbstractDuckFactory factory = new CountingDuckFactory();
            duckSimulator.Simulate(factory);
        }
    }
}
