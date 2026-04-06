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
            // Выбор платежного шлюза (например, PayPal)
            Console.WriteLine("Choose gateway: \n1. PayPalGateway\n2. CreditCardGateway");
            var input = Console.ReadLine();
            IPaymentGateway gateway = input switch
            {
                "1" => new PayPalGateway(),
                "2" => new CreditCardGateway(),
                _ => throw new NotImplementedException(),
            };
            
            Console.WriteLine("Input amount to pay (PayPal balance is 1000)");
            PaymentProcessor processor = new OnlinePaymentProcessor(gateway);
            input = Console.ReadLine();
            if (input == null)
            {
                processor.ProcessPayment(2450m);
                Console.ReadLine();
                return;
            }
            
            int amount = int.Parse(input);

            try
            {
                processor.ProcessPayment(amount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n ...Changing Strategy");
                processor.ChangeGateway(new CreditCardGateway());
                processor.ProcessPayment(amount);
            }

            Console.ReadLine();
        }
    }
}