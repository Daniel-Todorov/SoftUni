namespace RestaurantManager.Models
{
    using System;

    using RestaurantManager.Interfaces;
    using System.Text;

    internal class Drink : Recipe, IDrink
    {
        private bool isCarbonated;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, MetricUnit.ml, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
        }

        public override int Calories
        {
            get
            {
                return base.Calories;
            }
            protected set
            {
                if (value > 100)
                {
                    throw new ArgumentOutOfRangeException("The calories of a drink must not be greater than 100.");
                }

                base.Calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get
            {
                return base.TimeToPrepare;
            }
            protected set
            {
                if (value > 20)
                {
                    throw new ArgumentOutOfRangeException("The timeToPrepare of a drink must not be greater than 20.");
                }

                base.TimeToPrepare = value;
            }
        }

        public bool IsCarbonated
        {
            get
            {
                return this.isCarbonated;
            }
            private set
            {
                this.isCarbonated = value;
            }
        }

        public override string ToString()
        {
            //==  <name> == $<price>
            //Per serving: <quantity> <unit>, <calories> kcal
            //Ready in <time_to_prepare> minutes
            //Carbonated: <yes / no>

            StringBuilder result = new StringBuilder();

            result.Append(string.Format("==  {0} == ${1:0.00}{2}", this.Name, this.Price, Environment.NewLine));
            result.Append(base.ToString());
            result.Append(string.Format("Carbonated: {0}{1}", this.IsCarbonated ? "yes" : "no", Environment.NewLine));

            return result.ToString();
        }
    }
}
