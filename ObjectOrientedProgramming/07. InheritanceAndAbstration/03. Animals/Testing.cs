//Create an abstract class Animal holding name, age and gender.
//•	Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. 
//Dogs, frogs and cats are animals. 
//Kittens are female cats and Tomcats are male cats. 
//Define useful constructors and methods. 
//•	Define an interface ISound which implements the method ProduceSound(). 
//All animals should implement this interface. 
//The ProduceSound() method should produce a specific sound according to the animal (e.g. the dog should bark).
//•	Create arrays of different kinds of animals and calculate the average age of each kind of animal using LINQ.

namespace _03.Animals
{
    using System;
    using System.Linq;

    public class Testing
    {
        public static void Main()
        {
            Animals[] animals = new Animals[5];
            animals[0] = new Tomcat("Vanko", 4);
            animals[1] = new Kitten("Mucka", 2);
            animals[2] = new Dog("Sharo", 10, Gender.Male);
            animals[3] = new Frog("Jabcho", 1, Gender.Male);
            animals[4] = new Cat("Pisanka", 5, Gender.Female);

            //System.Console.WriteLine(animals[0].GetType());

            var avarageAgeOfCats = animals.Where(animal => Testing.IsSameOrSubclass(typeof(Cat), animal.GetType())).Average(cat => cat.Age);
            var avarageAgeOfDogs = animals.Where(animal => Testing.IsSameOrSubclass(typeof(Dog), animal.GetType())).Average(dog => dog.Age);
            var avarageAgeOfFrogs = animals.Where(animal => Testing.IsSameOrSubclass(typeof(Frog), animal.GetType())).Average(frog => frog.Age);
            Console.WriteLine("Avarage age of cats = {0}", avarageAgeOfCats);
            Console.WriteLine("Avarage age of dogs = {0}", avarageAgeOfDogs);
            Console.WriteLine("Avarage age of Frogs = {0}", avarageAgeOfFrogs);
        }

        private static bool IsSameOrSubclass(Type potentialBase, Type potentialDescendant)
        {
            return potentialDescendant.IsSubclassOf(potentialBase)
                   || potentialDescendant == potentialBase;
        }
    }
}
