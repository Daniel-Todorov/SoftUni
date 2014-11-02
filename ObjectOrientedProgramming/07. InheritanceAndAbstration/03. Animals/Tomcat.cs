//•	Create a hierarchy with classes Dog, Frog, Cat, Kitten and Tomcat. 
//Kittens are female cats and Tomcats are male cats. 

namespace _03.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
        }
    }
}