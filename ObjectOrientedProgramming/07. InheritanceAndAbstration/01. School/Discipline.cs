namespace _01.School
{
    using System.Collections.Generic;

    public class Discipline : Detailable
    {
        public Discipline()
        {
            this.Students = new List<Student>();
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public List<Student> Students { get; set; }
    }
}
