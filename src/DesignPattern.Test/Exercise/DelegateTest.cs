using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core.Delegate;
using Xunit;

namespace DesignPattern.Test.Exercise
{
    public class DelegateTest
    {
        [Fact]
        public void TeacherDelegateTest()
        {
            var teacher = new Teacher("Mr.Tom");
            var student = new Student("Bob");
            var student2 = new Student("Lee");

            teacher.TeacherCome += new Teacher.EventHandler(student.StopWisper);
            teacher.TeacherCome += new Teacher.EventHandler(student2.StopCopyWork);

            teacher.Come();
        }
    }
}
