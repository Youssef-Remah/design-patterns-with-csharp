namespace PaymentGatewayIntegration.AbstractProduct
{
    /// <summary>
    /// Defines the contract for payment gateway implementations.
    /// </summary>
    /// <remarks>
    /// This interface follows the Factory design pattern, representing 
    /// the abstract product role. Concrete implementations (e.g., PayPal, Stripe, CreditCard) 
    /// are responsible for providing the specific payment processing logic.
    /// </remarks>
    public interface IPaymentGateway
    {
        /// <summary>
        /// Processes a payment for the specified amount using the gateway implementation.
        /// </summary>
        /// <param name="paymentAmount">
        /// The amount of money to process.
        /// </param>
        void ProccessPayment(double paymentAmount);
    }
}
