namespace ECommerceMVP.Visitor;

public class OrderReportVisitor: IOrderVisitor
{
    private decimal _total_amount = 0;
    
    public void PrintReport()
    {
        Console.WriteLine("Order Report - Total Amount: {0}", _total_amount);
    }

    public void Visit(Order order)
    {
        _total_amount = order.TotalAmount;
    }
}