using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.PermissionRoom
{
    public class RCAControl : RemoteControl
    {
        public override void On()
        {
            Console.WriteLine("RCA Control is on.");
        }

        public override void Off()
        {
            Console.WriteLine("RCA Control is off.");
        }

        public override void SetChannel()
        {
            Console.WriteLine("RCA Control is set dest channel.");
        }
    }
}
