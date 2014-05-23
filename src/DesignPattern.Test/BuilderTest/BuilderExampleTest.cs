using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Builder.RealWorld;
using DesignPattern.Core.Builder.Structural;
using Xunit;

namespace DesignPattern.Test.BuilderTest
{
    public class BuilderExampleTest
    {
        [Fact]
        public void StructuralTest()
        {
            Director director = new Director();

            Builder build1 = new ConcreteBuilder();
            Builder build2 = new ConcreteBuilder2();

            director.Construct(build1);

            director.Construct(build2);

            Product product1 = build1.GetResult();
            Product product2 = build2.GetResult();

            product1.Show();
            product2.Show();
        }

        [Fact]
        public void RealWorldTest()
        {
            Shop shop = new Shop();

            VehicleBuilder builder;

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.GetVehicleInstance().Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.GetVehicleInstance().Show();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.GetVehicleInstance().Show();

        }
    }
}
