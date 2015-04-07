using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    public abstract class Product : IProduct
    {
        private string name;
        private string brand;

        public Product(string name, string brand, decimal price, GenderType genderType)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = genderType;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name can not be null!");
                }
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new IndexOutOfRangeException("Product name must be between 3 and 10 symbols long!");
                }
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Brand can not be null!");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new IndexOutOfRangeException("Product brand must be between 2 and 10 symbols long!");
                }
                this.brand = value;
            }
        }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; private set; }

        public string Print()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("- {0} - {1}:\n", this.Brand, this.Name);
            sb.AppendFormat("  * Price: {0:C}\n", this.Price);
            sb.AppendFormat(new CultureInfo("en-US"),"  * For gender: {0}", this.Gender.ToString());

            return sb.ToString();
        }
    }
}
