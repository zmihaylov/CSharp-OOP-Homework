namespace FurnitureManufacturer.MyClasses
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class Company : ICompany
    {
        private string name;
        private string registrationNumber;

        public Company(string name, string regNumber)
        {
            this.Name = name;
            this.RegistrationNumber = regNumber;
            this.Furnitures = new List<IFurniture>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 10 || !IsDigitsOnly(value))
                {
                    throw new ArgumentException("Invalid number");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures { get; private set; }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in this.Furnitures)
            {
                if (furniture.Model.ToLower() == model.ToLower())
                {
                    return furniture;
                }
            }
            return null;
        }

        public string Catalog()
        {
            var orderdFurniture = this.Furnitures
                .OrderBy(f => f.Price)
                .ThenBy(f => f.Model)
                .ToList();

            StringBuilder sb = new StringBuilder();

            if (this.Furnitures.Count == 0)
            {
                sb.Append(this.ToString());
            }
            else
            {
                sb.AppendLine(this.ToString());
                sb.Append(string.Join("\n", orderdFurniture));
            }
            
            
            //foreach (var furniture in orderdFurniture)
            //{
            //    sb.AppendLine(furniture.ToString());
            //}

            return sb.ToString();
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} {3}", this.Name,
                                                        this.RegistrationNumber,
                                                        this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                                        this.Furnitures.Count != 1 ? "furnitures" : "furniture");
        }
    }
}
