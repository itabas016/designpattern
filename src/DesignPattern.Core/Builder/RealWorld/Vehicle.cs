using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Builder.RealWorld
{
    public class Vehicle
    {
        public string VehicleType { get; set; }

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicle)
        {
            this.VehicleType = vehicle;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Vehicle Type: {0}", VehicleType);
            Console.WriteLine("Frame:{0}", _parts["frame"]);
            Console.WriteLine("Engine:{0}", _parts["engine"]);
            Console.WriteLine("Wheels:{0}", _parts["wheels"]);
            Console.WriteLine("Doors:{0}", _parts["doors"]);
        }
    }
}
