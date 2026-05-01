namespace ECommerceMVP.Mediator.Modules;

public class ShippingModule: IMediatorModule
{
    private IMediator _mediator;

    public ShippingModule(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void OnNotify(string order)
    {
        if (order.ToLower() == "error")
        {
            Console.WriteLine("Error");
            _mediator.Notify(this, "Error");
            return;
        }
        Console.WriteLine("ShippingModule");
        _mediator.Notify(this, order);
    }
}