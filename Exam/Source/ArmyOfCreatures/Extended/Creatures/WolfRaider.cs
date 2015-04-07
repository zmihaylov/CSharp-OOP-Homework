using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class WolfRaider : Creature
    {
        private const int WolfRaiderAttack = 8;
        private const int WolfRaiderDefence = 5;
        private const int WolfRaiderHealthPoints = 10;
        private const decimal WolfRaiderDamage = 3.5M;


        public WolfRaider()
            : base(WolfRaiderAttack, WolfRaiderDefence, WolfRaiderHealthPoints, WolfRaiderDamage)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
