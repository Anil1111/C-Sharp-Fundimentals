using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Snake : Animal
    {
        public bool isVenomous { get; set; }

        public Snake()
        {

        }

        public Snake(string colour, bool isVenomous) : base(colour)
        {

        }

        public void Bite()
        {
            string bite = (isVenomous) ? String.Format("{0} venomous snake biting", Colour) : String.Format("harmless {0} snake biting", Colour);
            Console.WriteLine(bite);
        }

        public override void Eat(string food)
        {
            string eat = (isVenomous) ? String.Format("{0} venomous snake eating {1}", Colour, food) : String.Format("harmless {0} snake eating {1}", Colour, food);
        }
    }
}
