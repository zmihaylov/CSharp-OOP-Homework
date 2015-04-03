namespace WarMachines.MyClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using WarMachines.Interfaces;
    public class Pilot : IPilot
    {
        private string name;
        private List<IMachine> pilotsMachines;

        public Pilot(string name)
        {
            this.Name = name;
            this.pilotsMachines = new List<IMachine>();
        }
        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot must hava a name");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.pilotsMachines.Add(machine);
        }

        public string Report()
        {
            string pilotRow = string.Format(this.Name + " - {0} {1}", this.pilotsMachines.Count == 0 ? "no" : this.pilotsMachines.Count.ToString(),
                                                                    this.pilotsMachines.Count != 1 ? "machines" : "machine");
            StringBuilder sb = new StringBuilder();

            if (this.pilotsMachines.Count != 0)
            {
                var orderdMachines = this.pilotsMachines
                .OrderBy(m => m.HealthPoints)
                .ThenBy(m => m.Name)
                .ToList();

                sb.AppendLine(pilotRow);
                sb.Append(string.Join("\n", orderdMachines));
            }
            else
            {
                sb.Append(pilotRow);
            }

            return sb.ToString();
        }
    }
}
