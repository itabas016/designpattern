using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Delegate
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            this.Name = name;
        }

        public void StopWisper()
        {
            Console.WriteLine("Teacher is coming, {0} stop talking.", Name);
        }

        public void StopCopyWork()
        {
            Console.WriteLine("Teacher is coming, {0} stop cope work.", Name);
        }
    }
}
