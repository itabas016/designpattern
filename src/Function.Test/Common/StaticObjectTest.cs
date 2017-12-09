using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Function.Test.Common
{
    public class StaticObjectTest
    {
        public class Device : BaseDevice
        {
            static SerialNumber serialNumber = new SerialNumber("X-100000");
            static string model = "X";
            static Device()
            {
                Console.WriteLine("Device static constructor.");
                Console.WriteLine("Device Info: serialNumber: [{0}], model: [{1}]", serialNumber.ToString(), model);
            }
            public Device()
            {
                Console.WriteLine("Device constructor.");
            }

        }

        public class BaseDevice
        {
            static SerialNumber serialNumber = new SerialNumber();
            static BaseDevice()
            {
                Console.WriteLine("Base Device static constructor.");
                Console.WriteLine("Base Device Info: serialNumber: [{0}]", serialNumber);
            }
            public BaseDevice()
            {
                Console.WriteLine("Base Device constructor.");
            }
        }

        public class SerialNumber
        {
            public string _serialNumber;
            public SerialNumber(string serialNumber = "000000")
            {
                _serialNumber = serialNumber;
                Console.WriteLine("Initialize serialNumber: {0}", serialNumber);
            }
            public override string ToString()
            {
                return _serialNumber;
            }
        }

        [Fact]
        public void FieldInitinalizeTest()
        {
            var device = new Device();
            Console.Read();
        }
    }
}
