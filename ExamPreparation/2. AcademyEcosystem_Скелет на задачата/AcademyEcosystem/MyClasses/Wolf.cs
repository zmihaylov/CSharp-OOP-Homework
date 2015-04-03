using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem.MyClasses
{
    public class Wolf : Animal, ICarnivore
    {
        private const int WolfInitialSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, WolfInitialSize)
        {

        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size || animal.State == AnimalState.Sleeping)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}
