namespace WarMachines.MyClasses
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;
    public class Tank : Machine, ITank
    {
        private const double InitialHealthPoints = 100;
        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = InitialHealthPoints;
            ToggleDefenseMode();
        }
        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;

            if (this.DefenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else if (!this.DefenseMode)
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append(string.Format(" *Defense: {0}",this.DefenseMode ? "ON" : "OFF"));

            return sb.ToString();
        }
    }
}
