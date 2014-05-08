using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade.FamilyCinema
{
    /// <summary>
    /// 调谐器
    /// </summary>
    public class Tuner
    {
        public Amplifier Amplifier { get; set; }

        public void On() { }

        public void Off() { }

        public void SetAM() { }

        public void SetFM() { }

        public void SetFrequency() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
