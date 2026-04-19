// Program.cs (MVP)
using System;
using System.Collections.Generic;
using System.Linq;
using ECommerceMVP.Mediator;
using ECommerceMVP.Mediator.Modules;

namespace ECommerceMVP
{

    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new OrderMediator();
            InventoryModule inventory = new InventoryModule(mediator);
            PaymentModule payment = new PaymentModule(mediator);
            ShippingModule shipping = new ShippingModule(mediator);
            mediator.RegisterInventoryModule(inventory);
            mediator.RegisterPaymentModule(payment);
            mediator.RegisterShippingModule(shipping);
            inventory.CheckInventory("Check this Order");

            Console.ReadLine();
        }
    }
}