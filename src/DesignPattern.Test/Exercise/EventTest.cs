using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test.Exercise
{
    public class EventTest
    {

    }

    public class Number
    {
        public decimal MyNumber { get; set; }

        public Number(decimal number)
        {
            this.MyNumber = number;
        }
    }

    public interface INumberFactory
    {
        int GetInt(decimal number);
        decimal GetDecimal(decimal number);
        decimal Add(decimal d1, decimal d2);
    }

    public class NumberFactory : INumberFactory
    {
        public decimal MyNumber { get; set; }

        public int MyInt
        {
            get
            {
                return (Int32)MyNumber;
            }
        }

        public decimal MyDecimal
        {
            get
            {
                return MyNumber - (Int32)MyNumber;
            }
        }

        public int GetInt(decimal number)
        {
            return (Int32)number;
        }

        public decimal GetDecimal(decimal number)
        {
            return number - (Int32)number;
        }

        public decimal Add(decimal d1, decimal d2)
        {
            return d1 + d2;
        }
    }

    public class NumberManager
    {
        public event EventHandler<NumberArgs> Number;
    }

    public class NumberArgs : EventArgs
    {
        private readonly int _numberInt;
        private readonly decimal _numberDecimal;

        public NumberArgs(int numberInt, decimal numberDecimail)
        {
            _numberInt = numberInt;
            _numberDecimal = numberDecimail;
        }

        public int NumberInt { get { return _numberInt; } }
        public decimal NumberDecimal { get { return _numberDecimal; } }
    }

}
