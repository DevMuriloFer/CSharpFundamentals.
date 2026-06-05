using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Inheritance.Entities
{
    internal class Product
    {
        
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        virtual public string PriceTag()
        {
            return FormattableString.Invariant($"{Name} $ {Price:F2}");
        }
    }
}
