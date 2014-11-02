//Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. 
//Create a List<Student> with sample students. 
//These students will be used for the next few tasks.

namespace _03.Student
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Age: {2}, Faculty number: {3}, Phone: {4}, Email: {5}");
        }
    }
}
