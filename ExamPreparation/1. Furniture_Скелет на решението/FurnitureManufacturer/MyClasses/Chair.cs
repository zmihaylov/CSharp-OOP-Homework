namespace FurnitureManufacturer.MyClasses
{
    using FurnitureManufacturer.Interfaces;
    using System;
    public class Chair : Furniture, IChair
    {
        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs { get; private set; }

        public override string ToString()
        {
            return base.ToString() + " Legs: " + this.NumberOfLegs;
        }
    }
}
