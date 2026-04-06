namespace ECommerceMVP;

public class CreditCardGateway: IPaymentGateway
{
    public void Process(decimal amount)
    {
        Console.WriteLine($"CreditCardGateway: Processing Credit Card payment of ${amount}\n");
    }
}