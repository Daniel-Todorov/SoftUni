namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;
    using System;
    using System.Text;

    internal class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, MainCourseType type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = type;
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            //<[VEGAN] >==  <name> == $<price>
            //Per serving: <quantity> <unit>, <calories> kcal
            //Ready in <time_to_prepare> minutes
            //Type: <type>

            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0}==  {1} == ${2:0.00}{3}", this.IsVegan ? "[VEGAN] " : string.Empty, this.Name, this.Price, Environment.NewLine));
            result.Append(base.ToString());
            result.Append(string.Format("Type: {0}{1}", this.Type.ToString(), Environment.NewLine));

            return result.ToString();
        }
    }
}
