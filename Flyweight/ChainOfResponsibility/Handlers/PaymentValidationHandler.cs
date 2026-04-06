namespace ECommerceMVP;

public class PaymentValidationHandler: IOrderHandler
{
    private IOrderHandler? _nextHandler;

    public void SetNext(IOrderHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public void Handle(Order order)
    {
        if (order.FailureMessage == null)
        {
            Console.WriteLine(order.IsPaymentValid ? "PaymentValidationHandler: Payment validated." :
                "PaymentValidationHandler: Payment validation failed.");
            if (!order.IsPaymentValid) order.FailureMessage = "Payment validation failed.";
        }
        _nextHandler?.Handle(order);
    }
}