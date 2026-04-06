namespace ECommerceMVP;

public class OnlinePaymentProcessor: PaymentProcessor
{
    public OnlinePaymentProcessor(IPaymentGateway paymentGateway) : base(paymentGateway)
    {}

    public override void ProcessPayment(decimal amount)
    {
        _paymentGateway.Process(amount);
    }
}