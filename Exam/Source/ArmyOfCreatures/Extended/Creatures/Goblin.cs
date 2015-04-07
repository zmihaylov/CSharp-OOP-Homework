using ArmyOfCreatures.Logic.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class Goblin : Creature
    {
        private const int GoblinAttack = 4;
        private const int GoblinDefence = 2;
        private const int GoblinHealthPoints = 5;
        private const decimal GolblinDamage = 1.5M;

        public Goblin()
            : base(GoblinAttack, GoblinDefence, GoblinHealthPoints, GolblinDamage)
        {

        }
    }
}
