namespace ECommerceMVP;

public class DiscountValidationHandler: IOrderHandler
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
            if (order.TotalAmount > 2000)
            {
                Console.WriteLine("DiscountValidationHandler: discounts can be applied.");
            }
            else
            {
                Console.WriteLine("DiscountValidationHandler: discounts cannot be applied.");
            }
        }
        _nextHandler?.Handle(order);
    }
}