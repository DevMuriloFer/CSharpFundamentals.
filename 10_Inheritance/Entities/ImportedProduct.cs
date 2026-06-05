using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Inheritance.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee)
            :base (name, price)
        {
            this.CustomFee = customFee;
        }
        public override string PriceTag()
        {
            return FormattableString.Invariant($"{Name} $ {(Price + CustomFee):F2} (Customs fee: $ {CustomFee})");
        }
    }
}
