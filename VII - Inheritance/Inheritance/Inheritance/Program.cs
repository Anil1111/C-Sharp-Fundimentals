using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("green");
            animal.Eat("food");
            PrintColour(animal);

            Dog dog = new Dog("blue", "bichon");
            dog.Eat("bones");
            dog.Bark();
            PrintColour(dog);

            Snake snake = new Snake("yellow", false);
            snake.Bite();
            PrintColour(snake);

            HuntingDog huntingDog = new HuntingDog("pink", "staff", 120);
            huntingDog.Hunt();
            PrintColour(snake);

            Animal[] animals = new Animal[]
            {
                animal,
                dog,
                snake,
                huntingDog
            };

            Console.WriteLine("Iterating through the animalsc array\n");

            foreach (var a in animals)
                a.Eat("food for animals");
        }

        public static void PrintColour(Animal animal)
        {
            Console.WriteLine("The animal is: {0}\n", animal.Colour);
        }
    }
}
