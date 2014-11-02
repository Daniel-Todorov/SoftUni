//•	Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. 
//Dogs, frogs and cats are animals. 

namespace _03.Animals
{
    using System;

    public class Cat : Animals
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meaw, meaw!");
        }
    }
}