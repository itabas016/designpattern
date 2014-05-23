using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.PermissionRoom
{
    public class SonyControl : RemoteControl
    {
        public override void On()
        {
            Console.WriteLine("Sony Control is on.");
        }

        public override void Off()
        {
            Console.WriteLine("Sony Control is off.");
        }

        public override void SetChannel()
        {
            Console.WriteLine("Sony Control is set dest channel.");
        }
    }
}
