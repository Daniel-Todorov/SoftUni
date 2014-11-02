//•	Define an interface ISound which implements the method ProduceSound(). 
//All animals should implement this interface. 
//The ProduceSound() method should produce a specific sound according to the animal (e.g. the dog should bark).

namespace _03.Animals.Contracts
{
    public interface ISound
    {
        void ProduceSound();
    }
}
