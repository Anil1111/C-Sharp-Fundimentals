using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog()
        {

        }

        public Dog(string colour, string breed) : base(colour)
        {

        }

        public void Bark()
        {
            Console.WriteLine("{0} {1} dog barking", Colour, Breed);
        }

        public override void Eat(string food)
        {
            Console.WriteLine("{0} {1} dog eating {2}", Colour, Breed, food);
        }
    }
}
