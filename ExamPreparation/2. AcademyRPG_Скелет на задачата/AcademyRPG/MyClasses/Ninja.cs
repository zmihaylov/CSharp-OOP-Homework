using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG.MyClasses
{
    public class Ninja : Character, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
        }
        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var highestTargetPoints = availableTargets
                .Where(t => t.Owner != 0 && t.Owner != this.Owner)
                .Max(h => h.HitPoints);

            for (int i = 0; i < availableTargets.Count; i++)
            {
                var target = availableTargets[i];
                if (target.Owner != 0 && target.Owner != this.Owner && target.HitPoints == highestTargetPoints)
                {
                    return i;
                }
            }

            return -1;

            // Ivaylo way
            //var target = availableTargets
            //    .OrderByDescending(t => t.HitPoints)
            //    .FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner);

            //return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}
