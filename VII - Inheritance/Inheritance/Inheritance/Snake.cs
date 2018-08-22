using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Snake : Animal
    {
        public bool IsVenomous { get; set; }

        public Snake()
        {

        }
        // Base class Animal needs a constructor that takes 1 argument...
        public Snake(string colour, bool isVenomous) : base(colour)
        {
            this.IsVenomous = isVenomous;
        }

        public void Bite()
        {
            string bite = (IsVenomous) ? String.Format("{0} venomous snake biting", Colour) : String.Format("harmless {0} snake biting", Colour);
            Console.WriteLine(bite);
        }
    }
}
