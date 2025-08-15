using PaymentGatewayIntegration.AbstractProduct;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    public class CreditCardGateway : IPaymentGateway
    {
        public void ProccessPayment(double paymentAmount)
        {
            Console.WriteLine($"Initiating Credit Card transaction for ${paymentAmount}...");
        }
    }
}
