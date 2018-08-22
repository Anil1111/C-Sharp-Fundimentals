using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(2, 3, 4);

            Add(2.2, 4.5);
            Add(1.1, 3.6, 7.8);

            Add(2, 8.9);
            Add(2.0, 7, 5.5);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        // Not allowed since two overloaded methods cannot differ on by return type. //
        //public static void Add(int a, int b)
        //{
        //    Console.WriteLine("A is: {0}, B is: {1}", a, b);
        //}


    }
}
