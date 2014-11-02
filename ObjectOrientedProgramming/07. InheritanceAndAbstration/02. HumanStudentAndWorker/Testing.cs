//Define an abstract class Human holding a first name and a last name.
//•	Define a class Student derived from Human that has a field faulty number (5-10 digits / letters).
//•	Define a class Worker derived from Human with fields WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns the payment earned by hour by the worker. 
//•	Define the proper constructors and properties for the classes in your class hierarchy.
//•	Initialize a list of 10 students and sort them by faculty number in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by payment per hour in descending order.
//•	Merge the lists and then sort them by first name and last name.

namespace _02.HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Testing
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Todorov", "12jibba"));
            students.Add(new Student("Todor", "Ivanov", "12jirta"));
            students.Add(new Student("Daniel", "Todorov", "12yubba"));
            students.Add(new Student("Hristo", "Martinov", "u8jibba"));
            students.Add(new Student("Martin", "Hristov", "12jibsda"));
            students.Add(new Student("Cecilia", "Todorova", "18gduba"));
            students.Add(new Student("Ivan", "Vasilev", "iu8ibba"));
            students.Add(new Student("Sergei", "Borisov", "op0ibba"));
            students.Add(new Student("Boiko", "Mestan", "9o7ibba"));
            students.Add(new Student("Mitko", "Mitev", "11jibba"));
            var orderedStudents = students.OrderBy(student => student.FacultyNumber);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1}, FN: {2}", student.FirstName, student.LastName, student.FacultyNumber);
            }

            Console.WriteLine("-----------------------------------------");

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivana", "Todorova", 100M, 12));
            workers.Add(new Worker("Todora", "Ivanova", 123.56M, 8));
            workers.Add(new Worker("Daniela", "Todorova", 89.90M, 4));
            workers.Add(new Worker("Hristoza", "Martinova", 255.68M, 8));
            workers.Add(new Worker("Martina", "Hristova", 999.99M, 1));
            workers.Add(new Worker("Cecilia", "Todorova", 90.80M, 4));
            workers.Add(new Worker("Ivana", "Vasileva", 450M, 8));
            workers.Add(new Worker("Sergeika", "Borisova", 358.78M, 8));
            workers.Add(new Worker("Boika", "Mestanova", 450M, 6));
            workers.Add(new Worker("Mitka", "Miteva", 220.22M, 8));
            var orderedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

            foreach (var worker in orderedWorkers)
            {
                System.Console.WriteLine("{0} {1}, Money per hour: {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine("-----------------------------------------");

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            var orderedHumans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);

            foreach (var human in orderedHumans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
