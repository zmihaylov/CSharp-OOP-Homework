namespace FurnitureManufacturer.MyClasses
{
    using FurnitureManufacturer.Interfaces;
    using System;
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private decimal initialHeight;
        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.initialHeight = height;
        }
        public bool IsConverted { get; private set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;

            if (this.IsConverted)
            {
                this.Height = 0.10m;
            }
            else if (!this.IsConverted)
            {
                this.Height = this.initialHeight;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
