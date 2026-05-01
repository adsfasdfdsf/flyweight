namespace ECommerceMVP;
using ECommerceMVP.Mediator.Modules;

public interface IMediator
{
    void RegisterInventoryModule(IMediatorModule inventoryModule);
    void RegisterPaymentModule(IMediatorModule paymentModule);
    void RegisterShippingModule(IMediatorModule shippingModule);
    void Notify(object sender, string message);
}