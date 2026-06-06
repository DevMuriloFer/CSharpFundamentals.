namespace _11_AbstractMethods.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double income, int numberOfEmployees)
            : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        
        public override double TaxCalculator()
        {
            double tax;
            if (NumberOfEmployees <= 10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }
            return tax;
        }
    }
}
