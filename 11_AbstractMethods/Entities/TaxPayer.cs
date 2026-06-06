namespace _11_AbstractMethods.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double TaxCalculator();
        public string NameAndTax()
        {
            return FormattableString.Invariant($"{Name}: $ {TaxCalculator():F2}");
        }
    }
}
