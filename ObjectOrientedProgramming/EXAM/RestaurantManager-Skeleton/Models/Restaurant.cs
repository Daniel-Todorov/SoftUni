namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using RestaurantManager.Interfaces; 

    internal class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        private IList<IRecipe> recipes;

        public Restaurant(string name, string location, IList<IRecipe> recipes)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = recipes;
        }

        public Restaurant(string name, string location)
            : this(name, location, new List<IRecipe>())
        {
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

        public string Location
        {
            get
            {
                return this.location;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The location is required.");
                }

                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get
            {
                return this.recipes;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The recipes is required.");
                }

                this.recipes = value;
            }
        }

        public void AddRecipe(IRecipe recipe)
        {
            if (recipe == null)
            {
                throw new InvalidOperationException();
            }

            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            if (recipe == null)
            {
                throw new InvalidOperationException();
            }

            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));

            if (this.Recipes.Count <= 0)
            {
                result.Append("No recipes... yet");

                return result.ToString();
            }

            var drinks = this.Recipes.Where(recipe => recipe.GetType().Name.Equals("Drink")).OrderBy(recipe => recipe.Name).ToList();

            if (drinks.Count > 0)
            {
                result.AppendLine("~~~~~ DRINKS ~~~~~");

                foreach (var drink in drinks)
                {
                    result.Append(drink);
                }
            }

            var salads = this.Recipes.Where(recipe => recipe.GetType().Name.Equals("Salad")).OrderBy(recipe => recipe.Name).ToList();

            if (salads.Count > 0)
            {
                result.AppendLine("~~~~~ SALADS ~~~~~");

                foreach (var salad in salads)
                {
                    result.Append(salad);
                }
            }

            var mainCourses = this.Recipes.Where(recipe => recipe.GetType().Name.Equals("MainCourse")).OrderBy(recipe => recipe.Name).ToList();

            if (mainCourses.Count > 0)
            {
                result.AppendLine("~~~~~ MAIN COURSES ~~~~~");

                foreach (var course in mainCourses)
                {
                    result.Append(course.ToString());
                }
            }

            var desserts = this.Recipes.Where(recipe => recipe.GetType().Name.Equals("Dessert")).OrderBy(recipe => recipe.Name).ToList();

            if (desserts.Count > 0)
            {
                result.AppendLine("~~~~~ DESSERTS ~~~~~");

                foreach (var dessert in desserts)
                {
                    result.Append(dessert.ToString());
                }
            }

            return result.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }
    }
}
