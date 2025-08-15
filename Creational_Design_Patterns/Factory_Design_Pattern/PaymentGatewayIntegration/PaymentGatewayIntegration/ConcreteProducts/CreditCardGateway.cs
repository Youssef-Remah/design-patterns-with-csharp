using PaymentGatewayIntegration.AbstractProduct;

namespace PaymentGatewayIntegration.ConcreteProducts
{
    /// <summary>
    /// Represents a concrete implementation of the <see cref="IPaymentGateway"/> 
    /// for processing payments via credit card.
    /// </summary>
    /// <remarks>
    /// This class is a concrete product in the Factory design pattern.
    /// It provides the specific logic for handling credit card transactions, 
    /// while the client interacts only with the <see cref="IPaymentGateway"/> interface.
    /// </remarks>
    public class CreditCardGateway : IPaymentGateway
    {
        /// <summary>
        /// Processes a credit card payment for the specified amount.
        /// </summary>
        /// <param name="paymentAmount">
        /// The amount to be charged to the credit card.
        /// </param>
        public void ProccessPayment(double paymentAmount)
        {
            Console.WriteLine($"Initiating Credit Card transaction for ${paymentAmount}...");
        }
    }
}
