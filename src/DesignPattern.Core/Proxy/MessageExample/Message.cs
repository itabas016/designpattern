using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Proxy.MessageExample
{
    public class Message
    {
        public string MessageData { get; set; }

        public DateTime PublishTime { get; set; }

        public Message(string message, DateTime publishTime)
        {
            this.MessageData = message;
            this.PublishTime = publishTime;
        }
    }
}
