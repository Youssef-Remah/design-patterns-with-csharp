using PaymentGatewayIntegration.AbstractProduct;
using PaymentGatewayIntegration.ConcreteProducts;

namespace PaymentGatewayIntegration.Factory
{
    public static class PaymentGatewayFactory
    {
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
