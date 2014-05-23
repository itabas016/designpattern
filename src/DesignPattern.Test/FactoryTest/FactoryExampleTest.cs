using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Factory.Strcutural;
using Xunit;

namespace DesignPattern.Test.FactoryTest
{
    public class FactoryExampleTest
    {
        [Fact]
        public void StructuralTest()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
    }
}
