//•	Define a class Student derived from Human that has a field faulty number (5-10 digits / letters).

namespace _02.HumanStudentAndWorker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("facultyNumber", "Faculty number cannot be null.");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("facultyNumber", "Faculty number must be at least 5 characters long.");
                }

                if (value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("facultyNumber", "Faculty number must be at most 10 characters long.");
                }

                this.facultyNumber = value;
            }
        }
    }
}
