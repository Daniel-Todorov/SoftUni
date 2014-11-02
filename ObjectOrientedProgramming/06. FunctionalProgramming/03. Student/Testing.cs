namespace _03.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Testing
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student student = new Student()
            {
                FirstName = "Ivan",
                LastName = "Todorov",
                Email = "ivan_todorov@abv.bg",
                Age = 23,
                FacultyNumber = "2942734JF87",
                GroupNumber = 2,
                Phone = "0887768090",
                GroupName = "The killers",
                Marks = new List<int>() { 4, 5, 6, 4, 5}
            };
            students.Add(student);
            student = new Student()
            {
                FirstName = "Petar",
                LastName = "Yordanov",
                Email = "petar_yordanov@gmail.com",
                Age = 17,
                FacultyNumber = "2946734JF87",
                GroupNumber = 1,
                Phone = "+359887768090",
                GroupName = "The slackers",
                Marks = new List<int>() { 3, 3, 2, 2, 3 }
            };
            students.Add(student);
            student = new Student()
            {
                FirstName = "Veronica",
                LastName = "Stanislavova",
                Email = "vercheto@hotmail.com",
                Age = 45,
                FacultyNumber = "1046144JF87",
                GroupNumber = 3,
                Phone = "02887768090",
                GroupName = "The bwitches",
                Marks = new List<int>() { 6, 6, 6, 6, 6 }
            };
            students.Add(student);
            student = new Student()
            {
                FirstName = "Maria",
                LastName = "Shopova",
                Email = "mimeto@abv.bg",
                Age = 34,
                FacultyNumber = "104614KJF87",
                GroupNumber = 2,
                Phone = "028878090",
                GroupName = "The killers",
                Marks = new List<int>() { 4, 5, 4, 5, 4 }
            };
            students.Add(student);
            Console.WriteLine("---04. Problem---");
            //Problem 4. Students by Group
            //Print all students from group number 2. 
            //Use a LINQ query. Order the students by FirstName.
            List<Student> result = (from s in students
                                   where s.GroupNumber == 2
                                   orderby s.FirstName
                                   select s).ToList();
            foreach (var stud in result)
            {
                Console.WriteLine("{0} {1} => Group number: {2}", stud.FirstName, stud.LastName, stud.GroupNumber);
            }
            Console.WriteLine("---05. Problem---");
            //Problem 5. Students by First and Last Name
            //Print all students whose first name is before their last name alphabetically. Use a LINQ query.
            result = (from s in students
                      where s.FirstName.CompareTo(s.LastName) < 0
                      select s).ToList();
            foreach (var stud in result)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }
            Console.WriteLine("---06. Problem---");
            //Problem 6.	Students by Age
            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. 
            //The query should return only the first name, last name and age.
            var specialResult = (from s in students
                                 where 18 < s.Age && s.Age < 24
                                 select new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age }).ToList();
            foreach (var stud in specialResult)
            {
                Console.WriteLine("{0} {1}, Age: {2}", stud.FirstName, stud.LastName, stud.Age);
            }
            Console.WriteLine("---07. Problem---");
            //Problem 7. Sort Students
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions 
            //sort the students by first name and last name in descending order. 
            //Rewrite the same with LINQ query syntax.
            result = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).ToList();
            foreach (var stud in result)
            {
                Console.WriteLine("{0} {1}", stud.FirstName, stud.LastName);
            }
            Console.WriteLine("---08. Problem---");
            //Problem 8. Filter Students by Email Domain
            //Print all students that have email @abv.bg. 
            //Use LINQ.
            result = (from s in students
                      where s.Email.EndsWith("@abv.bg")
                      select s).ToList();
            foreach (var stud in result)
            {
                Console.WriteLine("{0} {1}, Email: {2}", stud.FirstName, stud.LastName, stud.Email);
            }
            Console.WriteLine("---09. Problem---");
            //Problem 9. Filter Students by Phone
            //Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). 
            //Use LINQ.
            result = (from s in students
                      where s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592") || s.Phone.StartsWith("+359 2")
                      select s).ToList();
            foreach (var stud in result)
            {
                Console.WriteLine("{0} {1}, Phone: {2}", stud.FirstName,  stud.LastName, stud.Phone);
            }
            Console.WriteLine("---10. Problem---");
            //Problem 10. Excellent Students
            //Print all students that have at least one mark Excellent (6). 
            //Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
            var excelentStudents = (from s in students
                                    where s.Marks.Contains(6)
                                    select new
                                    {
                                        FullName = s.FirstName + " " + s.LastName,
                                        Marks = string.Join(", ", s.Marks.ToArray())
                                    }).ToList();
            foreach (var stud in excelentStudents)
            {
                Console.WriteLine("{0}, Marks: {1}", stud.FullName, stud.Marks);
            }
            Console.WriteLine("---11. Problem---");
            //Problem 11. Weak Students
            //Write a similar program to the previous one to extract the students with exactly two marks "2". 
            //Use extension methods.
            var weakStudents = students.Where((s) =>
            {
                int count = 0;

                foreach (var mark in s.Marks)
                {
                    if (mark == 2)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).ToList();

            foreach (var stud in weakStudents)
            {
                Console.WriteLine("{0} {1}, Marks: {2}", stud.FirstName, stud.LastName, string.Join(", ", stud.Marks.ToArray()));
            }
            Console.WriteLine("---12. Problem---");
            //Problem 12. Students Enrolled in 2014
            //Extract and print the Marks of the students that enrolled in 2014 
            //(the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            result = students.Where(s => s.FacultyNumber[4] == '1' || s.FacultyNumber[4] == '4').ToList();
            foreach (var stud in result)
            {
                Console.WriteLine("{0} {1}, Faculty number: {2}", stud.FirstName, stud.LastName, stud.FacultyNumber);
            }
        }
    }
}