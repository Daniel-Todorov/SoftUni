namespace RestaurantManager.Engine.Factories
{
    using System;

    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;
    using RestaurantManager.Models;

    public class RecipeFactory : IRecipeFactory
    {
        public IDrink CreateDrink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            var newDrink = new Drink(name, price, calories, quantityPerServing, timeToPrepare, isCarbonated);

            return newDrink;
        }

        public ISalad CreateSalad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            var newSalad = new Salad(name, price, calories, quantityPerServing, timeToPrepare, containsPasta);

            return newSalad;
        }
        
        public IMainCourse CreateMainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {
            MainCourseType mainCourseType = (MainCourseType) Enum.Parse(typeof(MainCourseType), type);
            var newMainCourse = new MainCourse(name, price, calories, quantityPerServing, timeToPrepare, isVegan, mainCourseType);
 
            return newMainCourse;
        }

        public IDessert CreateDessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            var newDessert = new Dessert(name, price, calories, quantityPerServing, timeToPrepare, isVegan);

            return newDessert;
        }
    }
}
