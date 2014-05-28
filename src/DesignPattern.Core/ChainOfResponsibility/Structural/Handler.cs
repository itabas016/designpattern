using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.ChainOfResponsibility.Structural
{
    public abstract class Handler
    {
        protected Handler Successor { get; set; }

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

}
