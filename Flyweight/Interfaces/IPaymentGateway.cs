namespace ECommerceMVP;

public interface IPaymentGateway
{
    void Process(decimal amount);
}