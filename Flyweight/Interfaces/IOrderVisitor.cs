namespace ECommerceMVP;

public interface IOrderVisitor
{
    void Visit(Order order);
    void PrintReport();
}