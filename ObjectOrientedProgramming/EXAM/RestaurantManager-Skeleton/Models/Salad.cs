namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;
    using System;
    using System.Text;

    internal class Salad : Meal, ISalad
    {
        private bool containsPasta;

        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, true)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta
        {
            get
            {
                return this.containsPasta;
            }
            private set
            {
                this.containsPasta = value;
            }
        }

        public override string ToString()
        {
            //<[VEGAN] >==  <name> == $<price>
            //Per serving: <quantity> <unit>, <calories> kcal
            //Ready in <time_to_prepare> minutes
            //Contains pasta: <yes / no>

            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0}==  {1} == ${2:0.00}{3}", this.IsVegan ? "[VEGAN] " : string.Empty, this.Name, this.Price, Environment.NewLine));
            result.Append(base.ToString());
            result.Append(string.Format("Contains pasta: {0}{1}", this.ContainsPasta ? "yes" : "no", Environment.NewLine));

            return result.ToString();
        }
    }
}
