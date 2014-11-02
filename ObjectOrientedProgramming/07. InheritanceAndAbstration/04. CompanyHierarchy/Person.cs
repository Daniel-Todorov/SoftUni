namespace _04.CompanyHierarchy
{
    using System;

    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("id", "Id cannot be null or empty string.");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("firstName", "First name cannot be null or empty string.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("lastName", "Last name cannot be null or empty string.");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, ID: {2}", this.firstName, this.lastName, this.id);
        }
    }
}
