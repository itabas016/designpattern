using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Builder.RealWorld
{
    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle { get; set; }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

        public Vehicle GetVehicleInstance()
        {
            return Vehicle;
        }
    }
}
