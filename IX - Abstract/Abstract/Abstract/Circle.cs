using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double xCoordinate, double yCoordinate, double radius) : base(xCoordinate, yCoordinate)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius;
        }

        public override void Print()
        {
            Console.WriteLine("This is a circle entered in {0} with {1} radius and with {2} area", Center.ToString(), Radius, GetArea());
        }

        public double GetLength()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
