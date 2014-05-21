using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Proxy.MessageExample
{
    public class MessageFactory : IMessage
    {
        public IList<Message> Get()
        {
            //Connect DB
            return new List<Message>() { };
        }

        public bool Insert(Message message)
        {
            //Connect DB
            return true;
        }
    }
}
