﻿namespace FurnitureManufacturer.MyClasses
{
    using FurnitureManufacturer.Interfaces;
    using System;
    public class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {

        }
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
