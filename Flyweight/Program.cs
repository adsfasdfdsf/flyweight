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
            // Использование Flyweight для создания продуктов
            var flyweight = ProductFlyweightFactory.GetFlyweight("BrandA", "High Quality", "image.jpg");
            var products = new List<Product>();
            for (int i = 0; i < 10000; ++i)
            {
                var flyweightLoc = ProductFlyweightFactory.GetFlyweight("BrandA", "High Quality", "image.jpg");

                products.Add(new Product(i + 1, "Laptop", 200m, flyweightLoc));
            }
            Order order = new Order();
            order.AddProduct(products[0]);
            order.AddProduct(products[1]);
            order.AddProduct(products[2]);

            Console.WriteLine("Order Total (Flyweight): $" + order.GetTotalAmount());
            Console.WriteLine($"Flyweight used: {flyweight.Brand}, {flyweight.Description}");
            ProductFlyweightFactory.PrintStatistics();
            Console.ReadLine();
        }
    }
}