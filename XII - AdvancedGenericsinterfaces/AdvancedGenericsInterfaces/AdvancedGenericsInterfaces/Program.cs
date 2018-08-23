using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGenericsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var productsRepository = new Repository<Product>();

            productsRepository.Add(new Product
            {
                Id = 1,
                Name = "Onion",
                Category = "Food",
                Price = 46
            });

            productsRepository.Add(new Product
            {
                Id = 2,
                Name = "Bread",
                Category = "Food",
                Price = 27
            });

            foreach (var p in productsRepository.GetAll())
            {
                p.Print();
            }

            Console.ReadLine();
        }
    }
}
