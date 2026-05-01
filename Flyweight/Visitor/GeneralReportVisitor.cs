namespace ECommerceMVP.Visitor;

public class GeneralReportVisitor: IOrderVisitor
{
    private decimal _total_amount = 0;
    private decimal _order_count = 0;
    private double _tax = 0.2;
    private double _discount = 0.2;
    
    public void PrintReport()
    {
        Console.WriteLine("General Report - Amount: {0}", _total_amount);
        Console.WriteLine("Average Price: {0}", _total_amount/_order_count);
        Console.WriteLine("Tax: {0}", _tax * Convert.ToDouble(_total_amount));
        Console.WriteLine("Discount Rate: {0}", _discount * Convert.ToDouble(_total_amount));
        Console.WriteLine("Total Price: {0}", Convert.ToDouble(_total_amount) + 
            _tax * Convert.ToDouble(_total_amount) -_discount * Convert.ToDouble(_total_amount));
    }

    public void Visit(Order order)
    {
        _total_amount = order.TotalAmount;
        _order_count += 1;
    }
}