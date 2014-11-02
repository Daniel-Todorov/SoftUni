namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;
    using System;
    using System.Text;

    internal class Dessert : Meal, IDessert
    {
        private bool withSugar;

        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }

        public bool WithSugar
        {
            get
            {
                return this.withSugar;
            }
            private set
            {
                this.withSugar = value;
            }
        }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            //<[NO SUGAR] ><[VEGAN] >==  <name> == $<price>
            //Per serving: <quantity> <unit>, <calories> kcal
            //Ready in <time_to_prepare> minutes

            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0}{1}==  {2} == ${3:0.00}{4}", 
                this.WithSugar ? string.Empty : "[NO SUGAR] ", 
                this.IsVegan ? "[VEGAN] " : string.Empty, 
                this.Name, 
                this.Price,
                Environment.NewLine));
            result.Append(base.ToString() + Environment.NewLine);

            return result.ToString();
        }
    }
}
