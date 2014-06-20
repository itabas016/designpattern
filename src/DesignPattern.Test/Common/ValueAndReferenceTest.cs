using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test.Common
{
    public class ValueAndReferenceTest
    {
        public void ValueTypeAndReferenceTypeTest()
        {
            Point point1 = new Point(20, 30);
            Point point2 = point1;
            point2.X = 50;

            Console.WriteLine(point1.X);       // 20 (does this surprise you )
            Console.WriteLine(point2.X);       // 50

            Pen pen1 = new Pen("Black");
            Pen pen2 = pen1;
            pen2.Color = "Blue";

            Console.WriteLine(pen1.Color);     // Blue (or does this surprise you )
            Console.WriteLine(pen2.Color);     // Blue
        }
    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x; Y = y;
        }
    }

    public class Pen
    {
        public string Color { get; set; }

        public Pen(string color)
        { 
            Color = color;
        }

        ~Pen() { }
    }
}
