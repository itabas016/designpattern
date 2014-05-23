using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Builder.RealWorld
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            this.Vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildFrame()
        {
            Vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "500 cc";
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
