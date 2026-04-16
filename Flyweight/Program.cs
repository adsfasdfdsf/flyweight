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
            decimal orderAmount = 2450m;
            var orderContext = new OrderContext(orderAmount, "Electronics", "Samsung");
            string discountCode = "DISCOUNT 10% ON ALL";

            DiscountInterpreter interpreter = new DiscountInterpreter();
            decimal discount = interpreter.Interpret(discountCode, orderContext);
            Console.WriteLine($"Interpreter: Discount applied: ${discount}");

            Console.ReadLine();
        }
    }
}