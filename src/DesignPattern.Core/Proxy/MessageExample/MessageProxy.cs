using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Proxy.MessageExample
{
    public class MessageProxy : IMessage
    {
        public MessageFactory MessageFactory { get; set; }

        public MessageProxy()
        {
            MessageFactory = new MessageFactory();
        }
        public IList<Message> Get()
        {
            return MessageFactory.Get();
        }

        public bool Insert(Message message)
        {
            return MessageFactory.Insert(message);
        }
    }
}
