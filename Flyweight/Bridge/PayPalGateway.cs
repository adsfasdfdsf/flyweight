namespace ECommerceMVP;

public class PayPalGateway: IPaymentGateway
{
    public void Process(decimal amount)
    {
        if (amount > 1000) throw new Exception("Amount can't be greater than 1000");
        Console.WriteLine($"PayPalGateway: Processing PayPal payment of ${amount}");
    }
}