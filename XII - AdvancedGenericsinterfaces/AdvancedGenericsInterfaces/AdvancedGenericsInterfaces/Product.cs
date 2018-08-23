﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGenericsInterfaces
{
    public class Product : Model, IUpdateable<Product>
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public void Update(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Category = product.Category;
            Price = product.Price;
        }

        public override void Print()
        {
            Console.WriteLine("Id: {0}, Name: {1}, Category: {2}, Price: {3}", Id, Name, Category, Price);
        }
    }
}
