namespace RestaurantManager.Models
{
    using System;

    using RestaurantManager.Interfaces;
    using System.Text;

    internal abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;
        private MetricUnit unit;
        private int timeToPrepare;

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is required.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                CheckForPositiveValue("price", value);

                this.price = value;
            }
        }

        public virtual int Calories
        {
            get
            {
                return this.calories;
            }
            protected set
            {
                CheckForPositiveValue("calories", value);

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }
            private set
            {
                CheckForPositiveValue("quantityPerServing", value);

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit
        {
            get
            {
                return this.unit;
            }
            private set
            {
                this.unit = value;
            }
        }

        public virtual int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
            protected set
            {
                CheckForPositiveValue("timeToPrepare", value);

                this.timeToPrepare = value;
            }
        }

        private static void CheckForPositiveValue(string argumentName, decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The {0} must be positive.", argumentName);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("Per serving: {0} {1}, {2} kcal{3}", this.QuantityPerServing, this.Unit.ToString(), this.Calories, Environment.NewLine));
            result.Append(string.Format("Ready in {0} minutes{1}", this.TimeToPrepare, Environment.NewLine));

            return result.ToString();
        }
    }
}
