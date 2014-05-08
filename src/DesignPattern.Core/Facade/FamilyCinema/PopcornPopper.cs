using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade.FamilyCinema
{
    /// <summary>
    /// 爆米花
    /// </summary>
    public class PopcornPopper
    {
        public void On() { }

        public void Off() { }

        public void Pop() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
