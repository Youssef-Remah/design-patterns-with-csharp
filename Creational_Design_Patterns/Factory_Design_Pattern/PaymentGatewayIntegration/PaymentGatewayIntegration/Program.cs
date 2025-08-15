using PaymentGatewayIntegration.AbstractProduct;
using PaymentGatewayIntegration.Factory;

namespace PaymentGatewayIntegration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select payment provider: PayPal, Stripe, or CreditCard:");

            string gatewayType = Console.ReadLine();

            try
            {
                IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayType);

                paymentGateway.ProccessPayment(500.00);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
