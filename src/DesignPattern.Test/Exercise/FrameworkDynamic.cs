using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test.Exercise
{
    public sealed class FrameworkDynamic
    {
        //嵌套类
        private class SomeNestedType { }

        //常量、只读和静态字段
        private const Int32 SomeConstant = 1;
        private readonly Int32 SomeReadOnlyField = 2;
        private static Int32 SomeReadWriteField = 3;

        //类型构造器
        static FrameworkDynamic() { }

        //实例构造器
        public FrameworkDynamic(Int32 x) { }
        public FrameworkDynamic() { }

        //实例方法和静态方法
        private String InstanceMethod()
        {
            return null;
        }
        private static void Main() { }

        //实例属性
        public Int32 SomeProperty
        {
            get { return 0; }
            set { }
        }

        //实例有参属性（索引器）
        public Int32 this[String s]
        {
            get { return 0; }
            set { }
        }

        //实例事件
        public event EventHandler SomeEvent;
    }
}
