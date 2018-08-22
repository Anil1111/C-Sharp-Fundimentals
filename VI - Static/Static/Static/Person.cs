using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static int Count { get; private set; }

        // Constructor that take no arguments...
        public Person()
        {

        }
        // Constructor that takes three arguments...
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

            // Increment count by 1...
            Count++;
            // Decrement count by 1
            Count--;
        }

        public void PrintPerson()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Age: {2}", FirstName, LastName, Age);
        }

        public static void PrintCount()
        {
            Console.WriteLine("Number of people: {0}", Count);
        }
    }
}
