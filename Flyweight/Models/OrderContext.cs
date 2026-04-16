namespace ECommerceMVP;

public class OrderContext
{
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }

    public OrderContext(decimal amount, string category = "", string brand = "")
    {
        Amount = amount;
        Category = category;
        Brand = brand;
    }
}