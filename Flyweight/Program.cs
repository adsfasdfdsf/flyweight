// Program.cs (MVP)
using System;
using System.Collections.Generic;
using System.Linq;
using ECommerceMVP.Mediator;
using ECommerceMVP.Mediator.Modules;
using ECommerceMVP.Visitor;

namespace ECommerceMVP
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order { TotalAmount = 1000m },
                new Order { TotalAmount = 1500m },
                new Order { TotalAmount = 800m }
            };

            List<IOrderVisitor> visitors = new List<IOrderVisitor>
            {
                new OrderReportVisitor(),
                new StockAmountVisitor(),
                new GeneralReportVisitor(),
            };
            foreach (var order in orders)
            {
                foreach (var visitor in visitors)
                {
                    order.Accept(visitor);
                }
            }

            foreach (var visitor in visitors)
            {
                visitor.PrintReport();
            }
        }
    }
}