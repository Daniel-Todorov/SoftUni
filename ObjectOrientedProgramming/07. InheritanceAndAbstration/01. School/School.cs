//We are given a school. In the school, there are classes of students. 
//•	Each class has a set of teachers. 
//•	Each teacher teaches a set of disciplines. 
//•	Students have name and unique class number. 
//Classes have unique text identifier. 
//Teachers have name. 
//Disciplines have name, number of lectures and students. 
//Both teachers and students are people. 
//Students, classes, teachers and disciplines have details (optional field).
//Your task is to identify the classes (in terms of OOP) and their members, 
//encapsulate their fields, define the class hierarchy (inherit shared data and functionality).

namespace _01.School
{
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Classes = new List<Class>();
            this.Students = new List<Student>();
        }

        public List<Class> Classes { get; set; }

        public List<Student> Students { get; set; }
    }
}
