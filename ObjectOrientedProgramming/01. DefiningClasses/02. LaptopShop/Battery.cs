namespace _02.LaptopShop
{
    using System;

    public class Battery
    {
        private string batteryInformation;

        public Battery(string batteryInformation)
        {
            this.BatteryInformation = batteryInformation;
        }

        public string BatteryInformation 
        {
            get
            {
                return this.batteryInformation;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery information cannot be null or empty string.");
                }

                this.batteryInformation = value;
            }
        }
    }
}
