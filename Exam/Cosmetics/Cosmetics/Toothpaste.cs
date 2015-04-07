using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    public class Toothpaste : Product, IToothpaste
    {
        private string ingredient;
        private ICollection<string> allIngredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.allIngredients = new List<string>(ingredients);
        }
        public string Ingredients
        {
            get
            {
                if (this.allIngredients.Contains(this.ingredient))
                {
                    return this.ingredient;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("No such ingredient");
                }
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Ingredient can not be null!");
                }
                if (value.Length < 4 || value.Length > 12)
                {
                    throw new ArgumentOutOfRangeException("Each ingredient must be between 4 and 12 symbols long!");
                }
                this.ingredient = value;
                this.allIngredients.Add(this.ingredient);
            }
        }

        public override string ToString()
        {
            if (this.allIngredients.Count != 0)
            {
                return base.ToString() + string.Format("\n  * Ingredients: {0}", string.Join(", ", this.allIngredients));
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
