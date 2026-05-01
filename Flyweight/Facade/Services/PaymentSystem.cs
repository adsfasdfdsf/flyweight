namespace ECommerceMVP;

public class PaymentSystem
{
    public void ProcessPayment(Order order)
    {
        if (order.GetTotalAmount() > 4000)
        {
            throw new Exception("You do not have enough money");
        }
        Console.WriteLine($" - Processing payment of ${order.GetTotalAmount()}...");
    }

    public void ReturnMoney(Order order)
    {
        Console.WriteLine($" - Returning money of ${order.GetTotalAmount()}...");
    }
}