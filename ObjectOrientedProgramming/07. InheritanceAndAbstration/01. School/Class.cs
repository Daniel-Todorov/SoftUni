namespace _01.School
{
    using System.Collections.Generic;

    public class Class : Detailable
    {
        public Class()
        {
            this.Teachers = new List<Teacher>();
        }

        public List<Teacher> Teachers { get; set; }

        public string Identifier { get; set; }
    }
}
