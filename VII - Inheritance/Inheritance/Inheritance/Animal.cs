using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Colour { get; set; }

        public Animal()
        {

        }

        public Animal(string colour)
        {
            this.Colour = colour;
        }

        public void Eat(string food)
        {
            Console.WriteLine("{0} animal eating {1}", Colour, food);
        }
    }
}
