using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.MyClasses
{
    public class AggressionCatalyst : SupplementBase
    {
        private const int Aggression = 3;
        
        public AggressionCatalyst() : base(0,0,AggressionCatalyst.Aggression)
        {

        }
    }
}
