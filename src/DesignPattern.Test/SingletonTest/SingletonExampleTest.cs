using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Singleton.StaticSingleton;
using DesignPattern.Core.Singleton.Structural;
using Xunit;

namespace DesignPattern.Test.SingletonTest
{
    public class SingletonExampleTest
    {
        [Fact]
        public void StructualTest()
        {
            var s1 = DesignPattern.Core.Singleton.Structural.Singleton.Instance();
            var s2 = DesignPattern.Core.Singleton.Structural.Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("The instance is same ,this is singleton pattern.");
            }
            else
            {
                Console.WriteLine("The instance is not same.");
            }
        }

        [Fact]
        public void StaticSingletonTest()
        {
            var s1 = DesignPattern.Core.Singleton.StaticSingleton.Singleton.Instance;

            var s2 = DesignPattern.Core.Singleton.StaticSingleton.Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("The instance is same ,this is singleton pattern.");
            }
            else
            {
                Console.WriteLine("The instance is not same.");
            }
        }

        [Fact]
        public void LazySingletonTest()
        {
            var s1 = DesignPattern.Core.Singleton.LazySingleton.Singleton.GetInstance();

            var s2 = DesignPattern.Core.Singleton.LazySingleton.Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("The instance is same ,this is singleton pattern.");
            }
            else
            {
                Console.WriteLine("The instance is not same.");
            }
        }

        [Fact]
        public void SingletonBaseTest()
        {
            var client1 = Client.instance;
            var client2 = Client.instance;
            if (client1 == client2)
            {
                Console.WriteLine("The instance is same ,this is singleton pattern.");
            }
            else
            {
                Console.WriteLine("The instance is not same.");
            }
        }

        [Fact]
        public void ArraryTest()
        {
            var array = new String[] { "a", "b", "c" };

            foreach (var item in array)
            {
                Console.WriteLine("Foreach:" + item);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("For:" + array[i]);
            }
        }
    }
}
