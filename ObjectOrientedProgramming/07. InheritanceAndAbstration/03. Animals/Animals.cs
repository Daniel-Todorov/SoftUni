//Create an abstract class Animal holding name, age and gender.

namespace _03.Animals
{
    using System;

    using _03.Animals.Contracts;

    public abstract class Animals : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animals(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("name", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot have negative value.");
                }

                this.age = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("gender", "Gender cannot be null.");
                }

                this.gender = value;
            }
        }

        public abstract void ProduceSound();
    }
}