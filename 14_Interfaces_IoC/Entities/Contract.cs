using System.Text;
using System.Globalization;
using _14_Interfaces_IoC.Exceptions;

namespace _14_Interfaces_IoC.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public decimal ContractValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();
        public decimal TotalValue { get; set; }

        public Contract(int number, DateTime date, decimal contractValue)
        {
            if (contractValue < 200)
            {
                throw new InvalidContractValue();
            }
            if (number > 99999999 || number < 1)
            {
                throw new InvalidContractNumber();
            }
            Number = number;
            Date = date;
            ContractValue = contractValue;
        }

        public string InstallmentsNotePrinter()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Installment i in Installments)
            {
                sb.AppendLine(i.DueDate.ToString("dd/MM/yyyy") + " - " + i.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
