namespace ECommerceMVP;

// Заказ
public class Order
{
    public decimal TotalAmount { get; set; }
    public bool InStock { get; set; }
    public bool IsPaymentValid { get; set; }
    public string? FailureMessage { get; set; } = null;
    public decimal GetTotalAmount() => TotalAmount;
}