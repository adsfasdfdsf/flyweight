namespace ECommerceMVP;

public class InventoryCheckHandler: IOrderHandler
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
            Console.WriteLine(order.InStock
                ? "InventoryCheckHandler: Inventory check passed."
                : "InventoryCheckHandler: Inventory check failed.");
            if (!order.InStock)
            {
                order.FailureMessage = "Inventory check failed.";
            }
        }

        _nextHandler?.Handle(order);
    }
}