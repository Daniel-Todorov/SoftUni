//•	Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. 
//Dogs, frogs and cats are animals. 

namespace _03.Animals
{
    public class Dog : Animals
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Bau, bau!");
        }
    }
}