using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class Griffin : Creature
    {
        private const int GriffinAttack = 8;
        private const int GriffinDefence = 8;
        private const int GriffinHealthPoints = 25;
        private const decimal GriffinDamage = 4.5M;

        public Griffin()
            : base(GriffinAttack, GriffinDefence, GriffinHealthPoints, GriffinDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
