using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    public class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> cosmetics;

        public Category(string name)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
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
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new IndexOutOfRangeException("Category name must be between 2 and 15 symbols long!");
                }
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.cosmetics.Contains(cosmetics))
            {
                throw new ArgumentOutOfRangeException("Product {0} does not exist in category {1}!",cosmetics.Name,this.Name);   
            }

            this.cosmetics.Remove(cosmetics);
        }

        public string Print()
        {
            var orderedCosmetics = this.cosmetics
                .OrderBy(c => c.Brand)
                .ThenByDescending(c => c.Price)
                .ToList();

            StringBuilder sb = new StringBuilder();

            if (this.cosmetics.Count == 0)
            {
                sb.Append(this.ToString());
            }
            else
            {
                sb.AppendLine(this.ToString());
                sb.Append(string.Join("\n", orderedCosmetics));
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0} category - {1} {2} in total", this.Name, this.cosmetics.Count, this.cosmetics.Count != 1 ? "products" : "product");
        }
    }
}
