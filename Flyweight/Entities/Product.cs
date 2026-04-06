namespace ECommerceMVP;

// Продукт
public class Product
{
    public int Id { get; }
    public string Name { get; }
    public decimal Price { get; }
    
    public ProductFlyweight Flyweight { get; }
    
    public Product(int id, string name, decimal price, ProductFlyweight flyweight)
    {
        Id = id;
        Name = name;
        Price = price;
        Flyweight = flyweight;
    }
}