using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
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

        // The virtual keyword is used to modify a method, property, indexer or
        // event declaration and allow for it to be overridden in a derived class
        public virtual void Eat(string food)
        {
            Console.WriteLine("{0} animal eating {1}", Colour, food);
        }
    }
}
