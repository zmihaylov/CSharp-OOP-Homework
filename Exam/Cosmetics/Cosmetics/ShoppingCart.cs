using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics
{
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in this.products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
