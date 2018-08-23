using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            IVehicle[] vehicles = new IVehicle[]
                {
                    new Car(),
                    new Plane()
                };

            IFlyable[] thingsThatFly = new IFlyable[]
                {
                    new Plane(),
                    new Bird()
                };

            Console.WriteLine("Iterating through vehicles");

            foreach (var v in vehicles)
            {
                v.Move();
            }

            Console.WriteLine("Iterating through thingsThatFly");

            foreach (var t in thingsThatFly)
            {
                t.Fly();
            }

            Console.ReadLine();
        }
    }
}
