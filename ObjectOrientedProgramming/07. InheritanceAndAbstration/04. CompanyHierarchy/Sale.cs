namespace _04.CompanyHierarchy
{
    using System;

    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("productName", "Product name can't be null or empty string.");
                }

                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("date", "date can't be null.");
                }

                this.date = value;
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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("price", "We don't sell for free.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Date: {1}, Price: {2}", this.ProductName, this.Date, this.Price);
        }
    }
}
