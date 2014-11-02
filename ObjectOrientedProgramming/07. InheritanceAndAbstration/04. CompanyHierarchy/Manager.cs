namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee, IManager
    {
        private IList<Employee> employees;

        public Manager(string id, string firstName, string lastName, decimal salary, Department department, IList<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.employees = employees;
        }

        public Manager(string id, string firstName, string lastName, decimal salary, Department department)
            : this(id, firstName, lastName, salary, department, new List<Employee>())
        {
        }

        public IList<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("employees", "Employees can't have null value.");
                }

                this.employees = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Manager: " + base.ToString());
            foreach (var employee in this.Employees)
            {
                result.AppendLine("\t" + employee);
            }

            return result.ToString();
        }
    }
}
