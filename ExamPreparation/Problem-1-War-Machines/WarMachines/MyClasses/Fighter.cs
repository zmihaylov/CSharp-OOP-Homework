namespace WarMachines.MyClasses
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;
    public class Fighter : Machine, IFighter
    {
        private const double InitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = InitialHealthPoints;
            this.StealthMode = stealthMode;
        }
        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return sb.ToString();
        }
    }
}
