//Write a class Student that holds name and age. 
//Add an event PropertyChanged that should fire whenever a property of Student is changed, 
//displaying a message in the format Property changed: <property> (from <old value> to <new value>). 
//Create a custom PropertyChangedEventArgs class to keep the property name, old value and new value. 

namespace _03.StudentClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Student student = new Student("Peter", 22);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine(
                    "Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName,
                    eventArgs.OldValue,
                    eventArgs.NewValue);
            };

            student.Name = "Maria";
            student.Age = 19;
        }
    }
}
