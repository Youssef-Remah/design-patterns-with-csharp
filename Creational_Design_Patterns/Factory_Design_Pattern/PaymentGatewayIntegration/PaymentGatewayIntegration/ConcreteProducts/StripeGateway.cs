using PaymentGatewayIntegration.AbstractProduct;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    public class StripeGateway : IPaymentGateway
    {
        public void ProccessPayment(double paymentAmount)
        {
            Console.WriteLine($"Initiating Stripe transaction for ${paymentAmount}...");
        }
    }
}
