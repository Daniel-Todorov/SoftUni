namespace _03.PcCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Computer
    {
        private string name;

        public Computer(string name, Component processor, Component graphicCard, Component motherBoard)
            : this(name, processor, graphicCard)
        {
            this.MotherBoard = motherBoard;
        }

        public Computer(string name, Component processor, Component graphicCard)
            : this(name, processor)
        {
            this.GraphicCard = graphicCard;
        }

        public Computer(string name, Component processor)
            : this(name)
        {
            this.Processor = processor;
        }

        public Computer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the computer can't be null or empty.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Component Processor { get; set; }

        public Component GraphicCard { get; set; }

        public Component MotherBoard { get; set; }

        public decimal Price
        {
            get
            {
                decimal totalPrice = 0M;

                if (this.Processor != null)
                {
                    totalPrice += this.Processor.Price;
                }
                if (this.MotherBoard != null)
                {
                    totalPrice += this.MotherBoard.Price;
                }
                if (this.GraphicCard != null)
                {
                    totalPrice += this.GraphicCard.Price;
                }

                return totalPrice;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.Name);
            if (this.Processor != null)
            {
                result.AppendLine("Processor:");
                result.AppendLine(this.Processor.Name);
                result.AppendLine(this.Processor.Price.ToString("C", CultureInfo.CreateSpecificCulture("bg-BG")));
            }
            if (this.GraphicCard != null)
            {
                result.AppendLine("Graphic card:");
                result.AppendLine(this.GraphicCard.Name);
                result.AppendLine(this.GraphicCard.Price.ToString("C", CultureInfo.CreateSpecificCulture("bg-BG")));
            }
            if (this.MotherBoard != null)
            {
                result.AppendLine("MOtherboard:");
                result.AppendLine(this.MotherBoard.Name);
                result.AppendLine(this.MotherBoard.Price.ToString("C", CultureInfo.CreateSpecificCulture("bg-BG")));
            }
            result.AppendLine(string.Format("Total price: {0}", this.Price.ToString("C", CultureInfo.CreateSpecificCulture("bg-BG"))));

            return result.ToString();
        }
    }
}
