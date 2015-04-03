using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.MyClasses
{
    public class HealthCatalyst : SupplementBase
    {
        private const int Health = 3;

        public HealthCatalyst()
            : base(0, HealthCatalyst.Health, 0)
        {

        }
    }
}
