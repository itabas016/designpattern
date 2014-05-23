using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Builder.RealWorld
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            this.Vehicle = new Vehicle("Scooter");
        }
        public override void BuildFrame()
        {
            Vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "50 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }
    }
}
