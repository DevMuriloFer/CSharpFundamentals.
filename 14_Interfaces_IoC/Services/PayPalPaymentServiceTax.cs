namespace _14_Interfaces_IoC.Services
{
    internal class PayPalPaymentServiceTax : IPaymentServiceTax
    {
        public decimal InstallmentTax(decimal partialValue, int installmentNumber)
        {
            decimal monthlyInterest = partialValue * 0.01M * installmentNumber;
            decimal paymentFee = (partialValue + monthlyInterest) * 0.02M;
            return (paymentFee + monthlyInterest);
        }
    }
}
