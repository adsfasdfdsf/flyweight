namespace ECommerceMVP;

public abstract class PaymentProcessor
{
    protected IPaymentGateway _paymentGateway;

    public PaymentProcessor(IPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public abstract void ProcessPayment(decimal amount);

    public void ChangeGateway(IPaymentGateway gateway)
    {
        _paymentGateway = gateway;
    }
}