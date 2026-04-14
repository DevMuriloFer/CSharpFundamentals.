using System.Globalization;
namespace _04_TryCatch_InvariantCulture
{
    internal class Customer
    {
        public string Name;

        private double _accountBalance;
        public double AccountBalance
        {
            get { return _accountBalance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("""
                        The account balance can not be under 0 dollars.
                        This bank does not offer loans.
                        
                        """);
                }
                _accountBalance = value;
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 16)
                {
                    throw new ArgumentException("customers must be at least 16 years old");
                }
                _age = value;
            }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "Name: {0} // Age: {1} // Account Balance: ${2:N2}",
                Name, Age, AccountBalance);
        }
    }
}

