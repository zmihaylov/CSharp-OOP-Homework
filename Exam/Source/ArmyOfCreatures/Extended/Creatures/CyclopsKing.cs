using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class CyclopsKing : Creature
    {
        private const int CyclopsKingAttack = 17;
        private const int CyclopsKingDefence = 13;
        private const int CyclopsKingHealthPoints = 70;
        private const decimal CyclopsKingDamage = 18M;

        public CyclopsKing()
            : base(CyclopsKingAttack, CyclopsKingDefence, CyclopsKingHealthPoints, CyclopsKingDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
