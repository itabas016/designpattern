using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public interface IBridge
    {
        void AddData(List<IVisList> list);
    }
}
