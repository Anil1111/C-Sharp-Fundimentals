using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{

    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Increment(number);
            // Number is 5...
            Console.WriteLine("After calling the Increment method, the value of number is: {0}", number);

            int num = 0;
            ReferenceIncrement(ref num);
            // Number is 1...
            Console.WriteLine("After calling the RefIncrement method, the value of num is: {0}", num);

            Console.ReadLine();
        }

        public static void Increment(int number)
        {
            number = number + 1;
        }

        public static void ReferenceIncrement(ref int number)
        {
            number = number + 1;
        }
    }
}
