using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Builder.RealWorld
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.Vehicle = new Vehicle("Car");
        }
        public override void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "4";
        }
    }
}
