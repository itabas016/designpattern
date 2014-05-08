using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade.FamilyCinema
{
    /// <summary>
    /// 放大器 扩音器
    /// </summary>
    public class Amplifier
    {
        public Tuner Tuner { get; set; }

        public DVDPlayer DVDPlayer { get; set; }

        public CDPlayer CDPlayer { get; set; }

        public void On() { }

        public void Off() { }

        public void SetCD() { }

        public void SetDVD() { }

        public void SetStereoSound() { }

        public void SetSurroundSound() { }

        public void SetTuner() { }

        public void SetVolume() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
