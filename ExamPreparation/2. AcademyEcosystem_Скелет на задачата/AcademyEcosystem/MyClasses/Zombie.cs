using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem.MyClasses
{
    public class Zombie : Animal
    {
        private const int MeatFromZombie = 10;
        private const int ZombieSize = 0;

        public Zombie(string name, Point location)
            : base(name, location, ZombieSize)
        {

        }
        public override int GetMeatFromKillQuantity()
        {
            return MeatFromZombie;
        }
    }
}
