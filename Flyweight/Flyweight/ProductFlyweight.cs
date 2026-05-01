namespace ECommerceMVP;

public class ProductFlyweight
{
    public string Brand { get; }
    public string Description { get; }
    public string Icon { get; }

    public ProductFlyweight(string brand, string description, string icon)
    {
        Brand = brand;
        Description = description;
        Icon = icon;
    }
}