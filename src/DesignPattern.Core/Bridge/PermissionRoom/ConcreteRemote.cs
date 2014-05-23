using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.PermissionRoom
{
    public abstract class ConcreteRemote : RemoteControl
    {
        public static int CurrentStation { get; set; }

        public override void On()
        {
            throw new NotImplementedException();
        }

        public override void Off()
        {
            throw new NotImplementedException();
        }

        public override void SetChannel()
        {
            SetChannel(CurrentStation);
        }

        public void SetChannel(int station)
        {
            if (station < 0)
            {
                station = 0;
            }
            Console.WriteLine("The Channel Set {0}", station);
        }

        public void SetStation() { }

        public void PreviousChannel()
        {
            SetChannel(CurrentStation - 1);
        }

        public void NextChannel()
        {
            SetChannel(CurrentStation + 1);
        }
    }
}
