//Define a class Laptop that holds the following information about a laptop device: 
//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
//•	The model and price are mandatory. All other values are optional.
//•	Define two separate classes: a class Laptop holding an instance of class Battery.
//•	Define several constructors that take different sets of arguments (full laptop + battery information or only part of it). Use proper variable types.
//•	Add a method in the Laptop class that displays information about the given instance
//o	Tip: override the ToString() method
//•	Put validation in all property setters and constructors. 
//String values cannot be empty, and numeric data cannot be negative. 
//Throw exceptions when improper data is entered.

namespace _02.LaptopShop
{
    using System;
    using System.Text;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int? ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double? batteryLife;
        private decimal price;

        public Laptop
            (
            string model, decimal price, string manufacturer = null, string processor = null, int? ram = null,
            string graphicCard = null, string hdd = null, string screen = null, Battery battery = null, int? batteryLife = null
            )
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.ValidateString("Model", value, false);

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.ValidateString("Manufacturer", value);

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.ValidateString("Processor", value);

                this.processor = value;
            }
        }

        public int? Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ValidateNumeric("Ram", value);

                this.ram = value;
            }
        }

        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                this.ValidateString("GraphicCard", value);
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                this.ValidateString("Hdd", value);
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                this.ValidateString("Screen", value);
            }
        }

        public Battery Battery { get; set; }

        public double? BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                this.ValidateNumeric("Battery life", value);

                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.ValidateNumeric("Price", value);

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Model: {0}", this.Model));
            if (this.Manufacturer != null)
            {
                result.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            }
            if (this.Processor != null)
            {
                result.AppendLine(string.Format("Processor: {0}", this.Processor));
            }
            if (this.Ram != null)
            {
                result.AppendLine(string.Format("Ram: {0} GB", this.Ram));
            }
            if (this.GraphicCard != null)
            {
                result.AppendLine(string.Format("Graphic card: {0}", this.GraphicCard));
            }
            if (this.Hdd != null)
            {
                result.AppendLine(string.Format("HDD: {0}", this.Hdd));
            }
            if (this.Screen != null)
            {
                result.AppendLine(string.Format("Screen: {0}", this.Screen));
            }
            if (this.Battery != null)
            {
                result.AppendLine(string.Format("Battery: {0}", this.Battery.BatteryInformation));
            }
            if (this.BatteryLife != null)
            {
                result.AppendLine(string.Format("Battery life: {0}", this.BatteryLife));
            }
            result.AppendLine(string.Format("Price: {0}", this.Price));
            result.AppendLine(Environment.NewLine);

            return result.ToString();
        }

        private void ValidateNumeric(string propertyName, dynamic value)
        {
            if (value != null && value < 0)
            {
                throw new ArgumentException(string.Format("{0} cannot have negative value.", propertyName));
            }
        }

        private void ValidateString(string propertyName, string value, bool isNullAllowed = true)
        {
            if (!isNullAllowed)
            {
                throw new ArgumentException(string.Format("{0} cannot be null.", propertyName));
            }
            else if (value != null && value.Length == 0)
            {
                throw new ArgumentException(string.Format("{0} cannot be empty string.", propertyName));
            }
        }
    }
}
