using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", "Doe", 777);
            john.PrintPerson();

            Person jake = new Person("Jake", "Giles", 990);
            jake.PrintPerson();
        }
    }
}
