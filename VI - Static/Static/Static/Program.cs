using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.PrintCount();

            Person newton = new Person(firstName: "Isaac", lastName: "Newton", age: 373);
            newton.PrintPerson();

            Person.PrintCount();

            Person galileo = new Person("Galileo", "Galilei", 452);
            galileo.PrintPerson();

            Person.PrintCount();
            Console.WriteLine(MathsUtilities.Square(7));
            Console.WriteLine(MathsUtilities.Multiply(3, 5));

            Console.ReadLine();
        }
    }
}
