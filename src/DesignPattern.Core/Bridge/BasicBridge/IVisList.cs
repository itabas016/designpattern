using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Bridge.BasicBridge
{
    public interface IVisList
    {
        void AddLine(Product product);
        void RemoveLine(int num);
    }
}
