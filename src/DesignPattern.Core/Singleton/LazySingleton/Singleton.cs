using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Singleton.LazySingleton
{
    public class Singleton
    {
        protected static class SingletonHandle
        {
            public static Singleton instance = new Singleton();
        }

        public static Singleton GetInstance()
        {
            return SingletonHandle.instance;
        }
    }
}
