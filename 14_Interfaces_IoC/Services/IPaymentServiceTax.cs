namespace _14_Interfaces_IoC.Services
{
    internal interface IPaymentServiceTax
    {
        decimal InstallmentTax(decimal partialValue, int installmentNumber);
    }
}
