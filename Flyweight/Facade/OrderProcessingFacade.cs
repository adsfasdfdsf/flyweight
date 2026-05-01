namespace ECommerceMVP;

public class OrderProcessingFacade
{
    private DeliverySystem _deliverySystem;
    private InventorySystem _inventorySystem;
    private PaymentSystem _paymentSystem;
    public OrderProcessingFacade()
    {
        _deliverySystem = new DeliverySystem();
        _inventorySystem = new InventorySystem();
        _paymentSystem = new PaymentSystem();
    }
    
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Facade: Starting order processing...");
        _inventorySystem.CheckAvailability(order);
        try
        {
            _paymentSystem.ProcessPayment(order);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            _inventorySystem.ReturnItem(order);
            Console.WriteLine("Facade: Order processed failed.");
            return;
        }
        _deliverySystem.ScheduleDelivery(order);
        Console.WriteLine("Facade: Order processed successfully.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("Facade: Canceling order processing...");
        _inventorySystem.ReturnItem(order);
        _paymentSystem.ReturnMoney(order);
        _deliverySystem.CancelDelivery(order);
        Console.WriteLine("Facade: Order cancelled successfully.");
    }
}