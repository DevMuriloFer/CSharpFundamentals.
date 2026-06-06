namespace _11_AbstractMethods.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpanditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpanditures) 
            : base(name, anualIncome)
        {
            HealthExpanditures = healthExpanditures;
        }

        public override double TaxCalculator()
        {
            double tax;
            if (AnualIncome < 20_000)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }
            tax -= HealthExpanditures * 0.50;
            return tax;
        }
    }
}
