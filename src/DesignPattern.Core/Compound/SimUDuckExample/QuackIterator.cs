using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Compound.SimUDuckExample
{
    public class QuackIterator : Iterator
    {
        public List<IQuackable> QuackerList { get; set; }
        public int position = 0;

        public QuackIterator(List<IQuackable> quackList)
        {
            this.QuackerList = quackList;
        }

        public object Next()
        {
            IQuackable quack = QuackerList[position];
            position++;
            return quack;
        }

        public bool HasNext()
        {
            if (QuackerList.Count <= position)
            {
                return false;
            }
            return true;
        }
    }
}
