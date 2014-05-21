using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Delegate
{
    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            this.Name = name;
        }

        public delegate void EventHandler();

        public event EventHandler TeacherCome;

        public void Come()
        {
            Console.WriteLine("{0} teacher is coming.", Name);
            if (TeacherCome != null)
            {
                TeacherCome();
            }
        }
    }
}
