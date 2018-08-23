using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Shape
    {
        public Point Center { get; set; }

        public abstract double GetArea();

        public Shape()
        {

        }

        public Shape(double xCoordinate, double yCoordinate)
        {
            Center = new Point(xCoordinate, yCoordinate);
        }

        public abstract void Print();

    }
}
