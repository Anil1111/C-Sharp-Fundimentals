using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Dog class cannot be less accessible than HuntingDog...
    public class HuntingDog : Dog
    {
        public double Speed { get; set; }

        public HuntingDog()
        {

        }

        public HuntingDog(string colour, string breed, double speed) : base(colour, breed)
        {
            Speed = speed;
        }

        public void Hunt()
        {
            Console.WriteLine("{0} {1} hunting dog hunting with {2} mph speed", Colour, Breed, Speed);
        }
    }
}
