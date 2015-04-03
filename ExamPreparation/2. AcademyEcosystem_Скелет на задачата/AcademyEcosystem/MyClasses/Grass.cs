using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem.MyClasses
{
    public class Grass : Plant
    {
        private const int GrassInitialSize = 2;
        public Grass(Point location)
            : base(location, GrassInitialSize)
        {
        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += time;
            }
        }
    }
}
