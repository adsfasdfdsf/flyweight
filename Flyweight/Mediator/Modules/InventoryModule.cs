namespace ECommerceMVP.Mediator.Modules;
public class InventoryModule
{
    private IMediator _mediator;
    public InventoryModule(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void CheckInventory(string order)
    {
        Console.WriteLine("InventoryModule");
        if (Random.Shared.Next(0, 2) == 0)
        {
            _mediator.Notify(this, "Error");
            return;
        }
        _mediator.Notify(this, order);
    }
}