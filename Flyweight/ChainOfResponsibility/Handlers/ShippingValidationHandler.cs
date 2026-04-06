namespace ECommerceMVP;

public class ShippingValidationHandler: IOrderHandler
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
            Console.WriteLine("ShippingValidationHandler: Shipping available.");
        }
        _nextHandler?.Handle(order);
    }
}