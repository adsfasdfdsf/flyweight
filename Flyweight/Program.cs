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
            Order order = new Order
            {
                TotalAmount = 2450m,
                InStock = false,
                IsPaymentValid = true,
            };

            // Создаем цепочку обработчиков
            IOrderHandler inventoryHandler = new InventoryCheckHandler();
            IOrderHandler paymentHandler = new PaymentValidationHandler();
            IOrderHandler shippingHandler = new ShippingValidationHandler();
            IOrderHandler discountHandler = new DiscountValidationHandler();
            
            inventoryHandler.SetNext(paymentHandler);
            paymentHandler.SetNext(shippingHandler);
            shippingHandler.SetNext(discountHandler);
            // Запускаем обработку заказа
            inventoryHandler.Handle(order);
            
            if (order.FailureMessage != null) Console.WriteLine(order.FailureMessage);
            
            Console.ReadLine();
        }
    }
}