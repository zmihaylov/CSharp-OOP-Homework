using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    public class Shampoo : Product, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price = price * milliliters;
        }
        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            if (this.Milliliters != 0)
            {
                sb.AppendFormat("  * Quantity: {0} ml\n", this.Milliliters);
            }

            sb.AppendFormat("  * Usage: {0}", this.Usage);

            return sb.ToString();
        }
    }
}
