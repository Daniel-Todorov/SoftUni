//Define a class Person that has name, age and email. 
//The name and age are mandatory. 
//The email is optional. 
//Define properties that accept non-empty name and age in the range [1...100]. 
//In case of invalid argument, throw an exception. 
//Define a property for the email that accepts either null or non-empty string containing '@'. 
//Define two constructors. 
//The first constructor should take name, age and email. 
//The second constructor should take name and age only and call the first constructor. 
//Implement the ToString() method to enable printing persons at the console.

namespace _01.Persons
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age): this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name can't be null or empty string.");
                }
                else
                {
                    this.name = value;
                }
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
                if (1 >= value || value >= 100)
                {
                    throw new ArgumentOutOfRangeException("The age must be in range [1...100].");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Length == 0 || !value.Contains("@"))
                {
                    throw new ArgumentException("The email must contain '@'.");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Name: {0}", this.Name));
            result.AppendLine(string.Format("Age: {0}", this.Age));
            result.AppendLine(string.Format("Email: {0}", this.Email));
            result.AppendLine(Environment.NewLine);

            return result.ToString();
        }
    }
}
