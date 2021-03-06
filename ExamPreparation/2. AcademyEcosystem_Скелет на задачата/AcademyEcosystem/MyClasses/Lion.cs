﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem.MyClasses
{
    public class Lion : Animal, ICarnivore
    {
        private const int LionInitialSize = 6;

        public Lion(string name, Point location)
            : base(name, location, LionInitialSize)
        {

        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size * 2)
                {
                    this.Size++;
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }
    }
}
