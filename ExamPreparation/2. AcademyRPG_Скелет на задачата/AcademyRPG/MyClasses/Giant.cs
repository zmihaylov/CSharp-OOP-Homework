using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcademyRPG;

namespace AcademyRPG.MyClasses
{
    public class Giant : Character, IFighter, IGatherer
    {
        private bool hasGatheredStone;
        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
            this.hasGatheredStone = false;
            this.AttackPoints = 150;
        }
        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!hasGatheredStone)
                {
                    this.AttackPoints += 100;
                    hasGatheredStone = true;
                }
                return true;
            }
            return false;
        }
    }
}
