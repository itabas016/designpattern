using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Singleton.StaticSingleton
{
    public abstract class SingletonBase<T>
        where T : new()
    {
        private static T _instance = new T();

        public static T instance { get { return _instance; } }

        public static void Initialize(T instance)
        {
            _instance = instance;
        }

        public static void Reset()
        {
            _instance = default(T);
        }
    }
}
