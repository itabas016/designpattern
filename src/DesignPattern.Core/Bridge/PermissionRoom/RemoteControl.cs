using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.PermissionRoom
{
    public abstract class RemoteControl
    {
        public abstract void On();
        public abstract void Off();
        public abstract void SetChannel();
    }
}
