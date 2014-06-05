using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Singleton.StaticSingleton
{
    public class Singleton
    {
        private static Singleton _instance = new Singleton();

        static Singleton()
        {
        }

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get { return _instance; }
        }
    }
}
