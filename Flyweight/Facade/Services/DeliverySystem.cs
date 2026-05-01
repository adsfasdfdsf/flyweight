namespace ECommerceMVP;

public class DeliverySystem
{
    public void ScheduleDelivery(Order order)
    {
        Console.WriteLine(" - Scheduling delivery...");
        Console.WriteLine(" - Sending notification to customer...");
    }

    public void CancelDelivery(Order order)
    {
        Console.WriteLine(" - Returning item...");
    }
}