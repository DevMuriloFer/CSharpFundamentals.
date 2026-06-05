using System.Globalization;

namespace _10_Inheritance.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return FormattableString.Invariant($"{Name} (Used) $ {Price:F2} (Manufacture Data: {ManufactureDate.ToString("dd/MM/yyyy")})");
        }
    }
}
