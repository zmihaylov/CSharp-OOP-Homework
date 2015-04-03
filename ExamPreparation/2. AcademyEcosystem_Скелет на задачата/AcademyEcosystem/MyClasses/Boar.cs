using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem.MyClasses
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BoarInitialSize = 4;
        private const int BiteSizeConst = 2;
        private int biteSize;

        public Boar(string name, Point location)
            : base(name, location, BoarInitialSize)
        {
            this.biteSize = BiteSizeConst;
        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(this.biteSize);
            }
            return 0;
        }
    }
}
