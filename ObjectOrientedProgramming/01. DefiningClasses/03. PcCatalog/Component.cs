namespace _03.PcCatalog
{
    using System;

    public class Component
    {
        private string name;
        private string description;
        private decimal price;

        public Component(string name, decimal price, string description = null)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
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
                    throw new ArgumentException("The name of the component can't be null or empty string.");
                }
                else
                {
                    this.name = value;
                }
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price of the component have negative value.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (this.description != null && this.description.Length == 0)
                {
                    throw new ArgumentException("The description of a component can't be an empty string.");
                }
                else
                {
                    this.description = value;
                }
            }
        }
    }
}
