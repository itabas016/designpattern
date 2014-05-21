using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Proxy.MessageExample
{
    public interface IMessage
    {
        IList<Message> Get();
        bool Insert(Message message);
    }
}
