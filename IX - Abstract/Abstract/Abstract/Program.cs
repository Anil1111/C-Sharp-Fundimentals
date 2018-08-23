using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
                {
                    new Circle(xCoordinate: 1, yCoordinate: 2, radius: 4),
                    new Square(xCoordinate: 3.5, yCoordinate: 4.6, side: 12)
                };

            foreach (var shape in shapes)
            {
                shape.Print();
                if (shape is Circle)
                {
                    double length = (shape as Circle).GetLength();
                    Console.WriteLine("The area is: {0}\n", length);
                } else if (shape is Square)
                {
                    double diagonal = (shape as Square).GetDiagonal();
                    Console.WriteLine("The diagonal is: {0}", diagonal);
                }
            }
            Console.ReadLine();
        }
    }
}
