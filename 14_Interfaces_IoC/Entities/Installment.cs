namespace _14_Interfaces_IoC.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }

        public Installment(DateTime dueDate, decimal amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
