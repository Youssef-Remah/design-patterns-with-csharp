using PaymentGatewayIntegration.AbstractProduct;
using PaymentGatewayIntegration.ConcreteProducts;

namespace PaymentGatewayIntegration.Factory
{
    /// <summary>
    /// Provides a centralized mechanism for creating payment gateway instances.
    /// </summary>
    /// <remarks>
    /// This static class implements the Factory design pattern by creating 
    /// and returning concrete implementations of <see cref="IPaymentGateway"/> 
    /// based on the provided gateway type. This approach encapsulates object 
    /// creation logic and promotes loose coupling between the client and concrete classes.
    /// </remarks>
    public static class PaymentGatewayFactory
    {
        /// <summary>
        /// Creates and returns an <see cref="IPaymentGateway"/> instance based on the specified type.
        /// </summary>
        /// <param name="gatewayType">
        /// The type of payment gateway to create. Supported values are:
        /// <c>"paypal"</c>, <c>"stripe"</c>, and <c>"creditcard"</c>.
        /// </param>
        /// <returns>
        /// An instance of a class implementing <see cref="IPaymentGateway"/> 
        /// corresponding to the specified gateway type.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the <paramref name="gatewayType"/> is not a supported payment gateway.
        /// </exception>
        public static IPaymentGateway CreatePaymentGateway(string gatewayType)
        {
            return gatewayType.ToLower() switch
            {
                "paypal" => new PayPalGateway(),

                "stripe" => new StripeGateway(),

                "creditcard" => new CreditCardGateway(),

                _ => throw new ArgumentException("Invalid payment gateway type")
            };
        }
    }
}
