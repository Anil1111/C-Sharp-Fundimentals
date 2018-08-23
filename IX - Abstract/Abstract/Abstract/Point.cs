using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Point
    {
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        public Point()
        {

        }

        public Point(double xCoordinate, double yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public override string ToString()
        {
            return String.Format("({0} {1})", XCoordinate, YCoordinate);
        }
    }
}
