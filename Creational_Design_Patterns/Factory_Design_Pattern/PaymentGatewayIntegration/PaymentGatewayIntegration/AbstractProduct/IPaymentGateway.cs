namespace PaymentGatewayIntegration.AbstractProduct
{
    public interface IPaymentGateway
    {
        void ProccessPayment(double paymentAmount);
    }
}
