using PaymentGatewayIntegration.AbstractProduct;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    /// <summary>
    /// Represents a concrete implementation of the <see cref="IPaymentGateway"/> 
    /// for processing payments via Stripe.
    /// </summary>
    /// <remarks>
    /// This class is a concrete product in the Factory design pattern.
    /// It provides the specific logic for handling Stripe transactions, 
    /// while the client interacts only with the <see cref="IPaymentGateway"/> interface.
    /// </remarks>
    public class StripeGateway : IPaymentGateway
    {
        /// <summary>
        /// Processes a Stripe payment for the specified amount.
        /// </summary>
        /// <param name="paymentAmount">
        /// The amount to be charged via Stripe.
        /// </param>
        public void ProccessPayment(double paymentAmount)
        {
            Console.WriteLine($"Initiating Stripe transaction for ${paymentAmount}...");
        }
    }
}
