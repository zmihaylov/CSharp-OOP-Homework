using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class AncientBehemoth : Creature
    {
        private const int AncientBehemothAttack = 19;
        private const int AncientBehemothDefence = 19;
        private const int AncientBehemothHealthPoints = 300;
        private const decimal AncientBehemothDamage = 40M;

        public AncientBehemoth()
            : base(AncientBehemothAttack, AncientBehemothDefence, AncientBehemothHealthPoints, AncientBehemothDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
