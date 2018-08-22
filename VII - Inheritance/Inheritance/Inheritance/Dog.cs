using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Base class e.g Animal cant be less accessible than the Dog class...
    // public class Dog : public class Animal - GOOD
    // public class Dog : class Animal - BAD
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog()
        {

        }
        // Base class Animal needs a constructor that takes 1 argument...
        public Dog(string colour, string bread) : base(colour)
        {

        }

        public void Bark()
        {
            Console.WriteLine("{0} {1} dog barking", Colour, Breed);
        }


    }
}
