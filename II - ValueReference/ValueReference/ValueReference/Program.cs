using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            double numberDouble = 60.25;
            float numberFloat = 45.78f;

            // When writing to the console {0} represents the variable number {5}
            Console.WriteLine("Initially, the value of the number is: {0}", number);

            // More expamples including numberDouble and numberFloat
            Console.WriteLine("The values for Number: {0}\nNumberDouble: {1} \nNumberFloat: {2}", number, numberDouble, numberFloat);

            ModifyNumber(number);
            Console.WriteLine("After calling the ModifyNumber method, the value of the number is {0}", number);

            int[] numbers = new int[5];
            Console.WriteLine("Initially, the value of number[0] is: {0}", numbers[0]);
            Console.WriteLine("Initially, the value of number[1] is: {0}", numbers[1]);
            Console.WriteLine("Initially, the value of number[2] is: {0}", numbers[2]);
            Console.WriteLine("Initially, the value of number[3] is: {0}", numbers[3]);
            Console.WriteLine("Initially, the value of number[4] is: {0}", numbers[4]);

            ModifyArray(numbers);
            Console.WriteLine("After calling the ModifyArray method, the value of numbers[0] is {0}", numbers[0]);
            Console.WriteLine("After calling the ModifyArray method, the value of numbers[1] is {0}", numbers[1]);
            Console.WriteLine("After calling the ModifyArray method, the value of numbers[2] is {0}", numbers[2]);
            Console.WriteLine("After calling the ModifyArray method, the value of numbers[3] is {0}", numbers[3]);
            Console.WriteLine("After calling the ModifyArray method, the value of numbers[4] is {0}", numbers[4]);
            //System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            //Console.WriteLine("After calling the ModifyArray method, the value of numbers[5] is {0}", numbers[5]);

            Console.ReadLine();
        }

        public static void ModifyArray(int[] array)
        {
            // Array's are zero based //
            // 1st Element
            array[0] = 100;
            // 2nd Element
            array[1] = 200;
            // 3rd Element
            array[2] = 300;
            // 4th Element
            array[3] = 400;
            // 5th Element
            array[4] = 500;
            // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.
            // No 6th element in the Array...(int[] numbers = new int[5];)
            //array[5] = 600;
        }

        public static void ModifyNumber(int number)
        {
            number = 1000;
        }
    }
}
