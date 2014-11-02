namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthPlace { get; set; }
        public string Occupation { get; set; }
        public string Notes { get; set; }
        public DateTime Birthday { get; set; }


        public bool IsOlderThan(Student otherStudent)
        {
            bool isCurrentStudentOlder = this.Birthday < otherStudent.Birthday;

            return isCurrentStudentOlder;
        }
    }
}
