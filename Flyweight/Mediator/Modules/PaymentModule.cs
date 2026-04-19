namespace ECommerceMVP.Mediator.Modules;

public class PaymentModule
{
    private IMediator _mediator;

    public PaymentModule(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void ValidatePayment(string order)
    {
        if (order.ToLower() == "error")
        {
            Console.WriteLine("Error");
            _mediator.Notify(this, "Error");
            return;
        }
        Console.WriteLine("PaymentModule");
        _mediator.Notify(this, order);
    }
}