using PaymentGatewayIntegration.AbstractProduct;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    public class PayPalGateway : IPaymentGateway
    {
        public void ProccessPayment(double paymentAmount)
        {
            Console.WriteLine($"Initiating PayPal transaction for ${paymentAmount}...");
        }
    }
}
