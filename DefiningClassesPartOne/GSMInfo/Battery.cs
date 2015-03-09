namespace GSMInfo
{
    using System;
    public class Battery
    {
        // Task 1
        private string batteryModel;
        private int? batteryHoursIdle;
        private int? batteryHoursTalk;
        private BatteryType typeOfBattery; // Task 3

        // Task 2

        public Battery()
            : this(null, null, null,BatteryType.LiIon)
        {
            
        }
        public Battery(string model)
            : this(model, null, null,BatteryType.LiIon)
        {

        }
        public Battery(string batteryModel, int? hoursIdle, int? hoursTalk, BatteryType typeOfBattery)
        {
            this.BatteryModel = batteryModel;
            this.BatteryHoursIdle = hoursIdle;
            this.BatteryHoursTalk = hoursTalk;
            this.TypeOfBattery = typeOfBattery;
        }

        // Task 5

        public string BatteryModel
        {
            get { return this.batteryModel; }
            private set {this.batteryModel = value;}
        }

        public int? BatteryHoursIdle
        {
            get { return this.batteryHoursIdle; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery idle hours capacity!");
                }
                this.batteryHoursIdle = value;
            }
        }

        public int? BatteryHoursTalk
        {
            get { return this.batteryHoursTalk; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid battery talk hours capacity!");
                }
                this.batteryHoursTalk = value;
            }
        }

        public BatteryType TypeOfBattery
        {
            get { return this.typeOfBattery; }
            private set { this.typeOfBattery = value; }
        }
    }
}
