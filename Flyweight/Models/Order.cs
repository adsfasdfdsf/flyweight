namespace ECommerceMVP;

// Заказ
public class Order
{
    public decimal TotalAmount { get; set; }

    public decimal GetTotalAmount() => TotalAmount;
}