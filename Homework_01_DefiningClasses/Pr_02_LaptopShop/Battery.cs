using System;

namespace Pr_02_LaptopShop
{
    class Battery
    {
        private string battery;
        private double batteryLife;

        public Battery (string battery, double batteryLife)
        {
            this.Batt = battery;
            this.BatteryLife = batteryLife;
        }

        public string Batt
        {
            get { return this.battery; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery cannot be null or empty");
                }
                this.battery = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Battery life must be > 1");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            string outputBattery = "";

            if (!String.IsNullOrEmpty(this.Batt))
            {
                outputBattery += "battery: " + this.Batt + "\n";
            }
            if (this.batteryLife != 0)
            {
                outputBattery += "battery life: " + this.BatteryLife + " hours\n";
            }
            return outputBattery;
        }
    }
}
