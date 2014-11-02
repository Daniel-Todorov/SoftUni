//Create the following OOP class hierarchy:
//•	Person – general class for anyone, holding id, first name and last name.
//o	Employee – general class for all employees, holding the field salary and department. 
//The department can only be one of the following: Production, Accounting, Sales or Marketing.
//	Manager – holds a set of employees under his command.
//	RegularEmployee
//-	SalesEmployee – holds a set of sales. A sale holds product name, date and price.
//-	Developer – holds a set of projects. A project holds project name, project start date, details and a state (open or closed). 
//A project can be closed through the method CloseProject().
//o	Customer – holds the net purchase amount (total amount of money the customer has spent).
//Extract interfaces for each class. (e.g. IPerson, IEmployee, IManager, etc.) 
//The interfaces should hold their public properties and methods (e.g. IPerson should hold id, first name and last name). 
//Each class should implement its respective interface.
//Define proper constructors. 
//Avoid code duplication through abstraction. 
//Encapsulate all data and validate the input. 
//Throw exceptions where necessary. 
//Override ToString() in all classes to print detailed information about the object.
//Create several employees of type Manager, SalesEmployee and Developer and add them in a single collection. Finally, print them in a for-each loop.

namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Testing
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            SalesEmployee employee = new SalesEmployee("1234", "Ivan", "Todorov", 1000);
            employee.Sales.Add(new Sale("DanTod CMS", DateTime.Now, 99.99M));
            persons.Add(employee);
            Developer developer = new Developer("1235", "Daniel", "Todorov", 2000);
            developer.Projects.Add(new Project("DanTod CMS", DateTime.Now, "Super cool CMS for dummies."));
            persons.Add(developer);
            Manager manager = new Manager("1236", "Yordan", "Vasilev", 5000, Department.Marketing);
            manager.Employees.Add(employee);
            manager.Employees.Add(developer);
            persons.Add(manager);

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
