using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade.FamilyCinema
{
    /// <summary>
    /// 影院灯光
    /// </summary>
    public class TheaterLights
    {
        public void On() { }

        public void Off() { }

        public void Dim() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
