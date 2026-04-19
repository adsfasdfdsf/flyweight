// Program.cs (MVP)
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceMVP
{

    class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog(850);
            catalog.AddProduct(new Iterator.Product(1, "Laptop", 1500m));
            catalog.AddProduct(new Iterator.Product(2, "Smartphone", 800m));
            catalog.AddProduct(new Iterator.Product(3, "Headphones", 150m));

            Console.WriteLine("Iterator: Listing products in catalog:");
            foreach (var product in catalog)
            {
                if (product.Price > 500m)
                {
                    Console.WriteLine($" - {product.Name} (${product.Price})");
                }
            }

            Console.ReadLine();
        }
    }
}