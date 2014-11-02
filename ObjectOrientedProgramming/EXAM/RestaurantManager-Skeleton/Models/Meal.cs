namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;
    using System.Text;

    internal abstract class Meal : Recipe, IMeal
    {
        private bool isVegan;

        protected Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, MetricUnit.g, timeToPrepare)
        {
            this.IsVegan = isVegan;
        }

        public bool IsVegan
        {
            get
            {
                return this.isVegan;
            }
            private set
            {
                this.isVegan = value;
            }
        }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
