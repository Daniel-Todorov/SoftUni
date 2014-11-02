namespace _04.CompanyHierarchy
{
    using System;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(string id, string firstName, string lastName, decimal salary, Department department)
            :base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = Department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary can't be null orwith negative value.");
                }

                this.salary = value;
            }
        }

        public Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("department", "Department can't be null.");
                }

                this.department = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Salary: {0}, Department: {1}", this.Salary, this.Department);
        }
    }
}
