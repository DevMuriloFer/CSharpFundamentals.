using _14_Interfaces_IoC.Entities;

namespace _14_Interfaces_IoC.Services
{
    internal class InstallmentCalculator
    {
        public IPaymentServiceTax ServiceTax { get; set; }

        public InstallmentCalculator(IPaymentServiceTax serviceTax)
        {
            ServiceTax = serviceTax;
        }

        public void Generate(Contract contract, int quantityOfInstallments)
        {
            for(int installmentNumber = 1; installmentNumber <= quantityOfInstallments; installmentNumber++)
            {
                DateTime date = contract.Date.AddMonths(installmentNumber);
                decimal partialValue = contract.ContractValue / quantityOfInstallments;
                decimal tax = ServiceTax.InstallmentTax(partialValue, installmentNumber);
                decimal total = partialValue + tax;

                contract.Installments.Add(new Installment(date, total));
            }
        }
        public void TotalValue(Contract contract)
        {
            decimal total = 0.00M;
            foreach(Installment i in contract.Installments)
            {
                total += i.Amount;
            }
            contract.TotalValue = total;
        }
    }
}
