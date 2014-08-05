using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.Test.Common
{
    public class DisposeTest
    {

    }

    public class ResourceHolder : IDisposable
    {
        private bool isDispose = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                //释放托管堆资源
            }
            else
            {
                //释放非托管堆资源
            }
            disposing = true;
        }

        ~ResourceHolder()
        {
            Dispose(false);
        }
    }

}
