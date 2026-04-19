namespace ECommerceMVP;
using ECommerceMVP.Mediator.Modules;

public interface IMediator
{
    void RegisterInventoryModule(InventoryModule inventoryModule);
    void RegisterPaymentModule(PaymentModule paymentModule);
    void RegisterShippingModule(ShippingModule shippingModule);
    void Notify(object sender, string message);
}