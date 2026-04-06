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
            Order order = new Order { TotalAmount = 2450m };
            OrderProcessingFacade facade = new OrderProcessingFacade();
            facade.ProcessOrder(order);
            facade.CancelOrder(order);
            
            order.TotalAmount = 5000m;
            facade.ProcessOrder(order);

            Console.ReadLine();
        }
    }
}