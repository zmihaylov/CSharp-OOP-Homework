using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.MyClasses
{
    public class Weapon : SupplementBase
    {
        public Weapon()
            : base(0, 0, 0)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = 10;
                this.AggressionEffect = 3;
            }
        }
    }
}
